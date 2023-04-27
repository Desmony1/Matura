using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    internal class Server
    {
        private SqlConnection connection;
        private int clients = 0;
        public void Start()
        {
            IPEndPoint localEndPoint = new IPEndPoint(new IPAddress(new byte[] { 127, 0, 0, 1 }), 11111);
            Socket listener = new Socket(SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(localEndPoint);
            listener.Listen(10);

            connection = Database.Connect();

            Console.WriteLine("Started listening....");

            Socket client;
            while (true)
            {
                client = listener.Accept();
                Thread t = new Thread(new ParameterizedThreadStart(HandleClient));
                t.Start(client);
            }

        }

        public void HandleClient(object sock)
        {
            clients++;
            Console.WriteLine("Client connected current connections (" + clients + ")");
            Socket socket = (Socket)sock;

            byte[] buffer = new byte[1024];
            string msgReceived = null;
            int numBytesReceived;
            string response;
            try
            {
                do
                {
                    numBytesReceived = socket.Receive(buffer);
                    msgReceived = Encoding.ASCII.GetString(buffer, 0, numBytesReceived);

                    response = HandleMessage(msgReceived);
                    if (response != "")
                    {
                        socket.Send(Encoding.ASCII.GetBytes(response));
                    }
                } while (msgReceived != "disconnect") ;
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                clients--;
                Console.WriteLine("Client disconnected current connections (" + clients + ")");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error while communicating to client! Error: " + e.Message);
                socket.Close();
                clients--;
            }
        }

        public string HandleMessage(string message)
        {
            Console.WriteLine("Server received message: "+message);
            string response = "";
            if (message.StartsWith("import"))
            {
                Import(message.Substring(message.LastIndexOf(':')+1));
            }else if (message.StartsWith("GetSchools"))
            {
                Database.GetSchools().ForEach(school => response += school+",");
                response = response.Remove(response.Length-1);
            }else if (message.StartsWith("GetClasses"))
            {

                Database.GetClasses(message.Substring(message.LastIndexOf(':') + 1)).ForEach(classdesc => response += classdesc+",");
                response = response.Remove(response.Length - 1);
            }else if (message.StartsWith("GetStudents"))
            {
                string[] parameters = message.Substring(message.LastIndexOf(':') + 1).Split(',');
                Database.GetStudents(parameters[0], parameters[1]).ForEach(student => response += student + ",");
                response = response.Remove(response.Length - 1);
            }
            else if (message.StartsWith("GetTeachers"))
            {
                string[] parameters = message.Substring(message.LastIndexOf(':') + 1).Split(',');
                Database.GetTeachers(parameters[0], parameters[1]).ForEach(teacher => response += teacher + ",");
                response = response.Remove(response.Length - 1);
            }
            return response;
        }

        #region Import
        private void Import(string path)
        {
            StreamReader reader;
            String line = "line";
            int type = 0;
            Directory.EnumerateDirectories(path).ToList().ForEach(directory =>
            {
                String schooldesc = directory.Substring(directory.LastIndexOf("\\") + 1);
                InsertSchool(schooldesc);
                int schoolid = Database.GetIDSchool(schooldesc);
                Directory.EnumerateFiles(directory + "\\").ToList().ForEach(file =>
                {
                    String classdesc = file.Substring(file.LastIndexOf("\\") + 1).Replace(".txt", "");
                    InsertClass(schooldesc, classdesc);
                    reader = new StreamReader(file);
                    int classid = Database.GetIDClass(schooldesc, classdesc);

                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        if (line.Equals("**** Students ****"))
                            type = 1;
                        else if (line.Equals("**** Teachers ****"))
                            type = 2;
                        else
                        {
                            if (type == 1)
                            {
                                InsertStudent(schooldesc, classdesc, line);
                            }
                            else if (type == 2)
                            {
                                if (Database.GetIDTeacher(schooldesc, line) != Database.NOT_FOUND)
                                {
                                    InsertIntoTeaches(classdesc, schooldesc, line);
                                }
                                else
                                {
                                    InsertTeacher(schooldesc, line);
                                    InsertIntoTeaches(classdesc, schooldesc, line);
                                }
                            }
                        }
                    }
                    reader.Close();
                });
            });
        }

        private void InsertSchool(string schooldesc)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "insert into school (description) values ('" + schooldesc + "')";
            cmd.ExecuteNonQuery();
        }

        private void InsertClass(string schooldesc, string classdesc)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "insert into class (description, schoolid) values ('" + classdesc + "', " + Database.GetIDSchool(schooldesc) + ")";
            cmd.ExecuteNonQuery();
        }

        private void InsertStudent(string schooldesc, string classdesc, string studentdesc)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "insert into student (description, schoolid, classid) values ('" + studentdesc + "', " + Database.GetIDSchool(schooldesc) + ", " + Database.GetIDClass(schooldesc, classdesc) + ")";
            cmd.ExecuteNonQuery();
        }

        private void InsertTeacher(string schooldesc, string teacherdesc)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "insert into teacher (description, schoolid) values ('" + teacherdesc + "', " + Database.GetIDSchool(schooldesc) + ")";
            cmd.ExecuteNonQuery();
        }

        private void InsertIntoTeaches(string classdesc, string schooldesc, string teacherdesc)
        {
            int idschool = Database.GetIDSchool(schooldesc);
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "insert into teaches (classid, cschoolid, teacherid, tschoolid) values (" + Database.GetIDClass(schooldesc, classdesc) + ", " + idschool + ", " + Database.GetIDTeacher(schooldesc, teacherdesc) + ", " + idschool + ")";
            cmd.ExecuteNonQuery();
        }
        #endregion
    }
}
