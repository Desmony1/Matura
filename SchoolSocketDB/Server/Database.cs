using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
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

        public static int GetIDSchool(string description)
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

        public static int GetIDClass(string school, string classdesc)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select id from class where description = '" + classdesc + "' and schoolid='"+Database.GetIDSchool(school)+"'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (int)reader[0];
            }
            return NOT_FOUND;
        }

        public static int GetIDStudent(string school, string classdesc, string student)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select id from student where description = '" + student + "' and schoolid='" + Database.GetIDSchool(school) + "' and classid='"+Database.GetIDClass(school, classdesc)+"'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (int)reader[0];
            }
            return NOT_FOUND;
        }

        public static int GetIDTeacher(string school, string teacherdesc)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select id from teacher where description = '" + teacherdesc + "' and schoolid='" + Database.GetIDSchool(school) + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (int)reader[0];
            }
            return NOT_FOUND;
        }

        public static List<String> GetSchools()
        {
            List<String> schools = new List<String>();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select description from school";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                schools.Add((String)reader[0]);
            }
            reader.Close();
            return schools;
        }

        public static List<String> GetClasses(string schooldesc)
        {
            List<String> classes = new List<String>();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select description from class where schoolid="+GetIDSchool(schooldesc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                classes.Add((String)reader[0]);
            }
            reader.Close();
            return classes;
        }

        public static List<String> GetStudents(string schooldesc, string classdesc)
        {
            List<String> students = new List<String>();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select description from student where schoolid=" + GetIDSchool(schooldesc) + " and classid="+GetIDClass(schooldesc, classdesc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                students.Add((String)reader[0]);
            }
            reader.Close();
            return students;
        }

        public static List<String> GetTeachers(string schooldesc, string classdesc)
        {
            List<String> teachers = new List<String>();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "select t1.description from teaches t join teacher t1 on t1.id=t.teacherid and t1.schoolid=t.tschoolid where t.classid="+GetIDClass(schooldesc, classdesc)+" and t.cschoolid="+GetIDSchool(schooldesc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                teachers.Add((String)reader[0]);
            }
            reader.Close();
            return teachers;
        }
    }
}
