using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSocketDB
{
    internal class Database
    {
        public static readonly int NOT_FOUND = -1;
        private static SqlConnection connection;

        private static readonly string CONN_SERVER;
        private static readonly string CONN_DATABASE;
        private static readonly string CONN_USER_ID;
        private static readonly string CONN_PASSWORD;

        static Database()
        {
            if (CONN_SERVER == null && CONN_DATABASE == null && CONN_USER_ID == null && CONN_PASSWORD == null)
            {
                StreamReader sr = new StreamReader("C:\\temp\\SchoolDB\\config.txt");
                try
                {
                    CONN_SERVER = sr.ReadLine().Split('=')[1];
                    CONN_DATABASE = sr.ReadLine().Split('=')[1];
                    CONN_USER_ID = sr.ReadLine().Split('=')[1];
                    CONN_PASSWORD = sr.ReadLine().Split('=')[1];
                    Console.WriteLine("Database Config File read successfully!");
                    sr.Close();
                }
                catch(Exception ex)
                {
                    sr.Close();
                    Console.WriteLine("Error while reading Database Config File! Error: "+ex.Message);
                }

            }
        }

        private Database()
        {

        }

        private static SqlConnection GetConnection()
        {
            if(connection == null)
            {
                connection = new SqlConnection("server=" + CONN_SERVER + ";" +
                    "database=" + CONN_DATABASE + ";" +
                    "user id=" + CONN_USER_ID + ";" +
                    "password=" + CONN_PASSWORD + "; MultipleActiveResultSets=True");
            }
            return connection;
        }

        public static SqlConnection Connect()
        {
            GetConnection();
            connection.Open();
            return connection;
        }

        public static void Disconnect()
        {
            if (connection != null)
                connection.Close();
        }

        public int GetIDSchool(string description)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select id from school where description = '" + description + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (int)reader[0];
            }
            return NOT_FOUND;
        }

        public int GetIDClass(string school, string classdesc)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select id from class where description = '" + classdesc + "' and schoolid='"+this.GetIDSchool(school)+"'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (int)reader[0];
            }
            return NOT_FOUND;
        }

        public int GetIDStudent(string school, string classdesc, string student)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select id from student where description = '" + student + "' and schoolid='" + this.GetIDSchool(school) + "' and classid='"+this.GetIDClass(school, classdesc)+"'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (int)reader[0];
            }
            return NOT_FOUND;
        }

        public int GetIDTeacher(string school, string teacherdesc)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select id from teacher where description = '" + teacherdesc + "' and schoolid='" + this.GetIDSchool(school) + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (int)reader[0];
            }
            return NOT_FOUND;
        }
    }
}
