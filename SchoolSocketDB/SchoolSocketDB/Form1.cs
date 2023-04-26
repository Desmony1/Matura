using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSocketDB
{
    public partial class FMain : Form
    {

        SqlConnection connection;

        public static readonly int B_LEFT = 40;
        public static readonly int B_TOP = 40;
        public static readonly int B_RIGHT = 880;
        public static readonly int B_BOTTOM = 1100;

        private Font f = new Font("Arial", 16);
        private int linespace = 10;
        private int heightFont;
        int page = 0;
        List<String> lines;
        public FMain()
        {
            InitializeComponent();
            DisableAll();
            ResetSchoolItems();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
        }

        private void MIConnect_Click(object sender, EventArgs e)
        {
            if (!MIConnect.Checked)
            {
                MIDisconnect.Checked = false;
                MIConnect.Checked = true;
                connection = Database.Connect();
                MessageBox.Show("Successfully connected to the database!");
                EnableAll();
                ResetSchoolItems();
            }
        }

        private void MIDisconnect_Click(object sender, EventArgs e)
        {
            if (!MIDisconnect.Checked)
            {
                MIConnect.Checked = false;
                MIDisconnect.Checked = true;
                Database.Disconnect();
                connection = null;
                MessageBox.Show("Successfully disconnected from the database!");
                DisableAll();
                ClearAll();
            }
        }

        private void MIExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region import
        private void MIImport_Click(object sender, EventArgs e)
        {
            if(connection == null)
            {
                MessageBox.Show("There is no connection to the database!");
                return;
            }
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = "C:\\Temp\\SchoolDB\\";
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader;
                String line = "line";
                int type = 0;
                Directory.EnumerateDirectories(fbd.SelectedPath).ToList().ForEach(directory =>
                {
                    String schooldesc = directory.Substring(directory.LastIndexOf("\\")+1);
                    InsertSchool(schooldesc);
                    int schoolid = Database.GetIDSchool(schooldesc);
                    Directory.EnumerateFiles(directory + "\\").ToList().ForEach(file =>
                    {
                        String classdesc = file.Substring(file.LastIndexOf("\\") + 1).Replace(".txt", "");
                        InsertClass(schooldesc, classdesc);
                        reader = new StreamReader(file);
                        int classid = Database.GetIDClass(schooldesc, classdesc);

                        while(!reader.EndOfStream){
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
                MessageBox.Show("Data successfully imported!");
                ResetSchoolItems();
            }

        }

        #endregion

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
            cmd.CommandText = "insert into student (description, schoolid, classid) values ('" + studentdesc + "', " + Database.GetIDSchool(schooldesc) + ", "+Database.GetIDClass(schooldesc, classdesc)+")";
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
            cmd.CommandText = "insert into teaches (classid, cschoolid, teacherid, tschoolid) values ("+Database.GetIDClass(schooldesc, classdesc)+", "+idschool+", "+Database.GetIDTeacher(schooldesc, teacherdesc)+", "+idschool+")";
            cmd.ExecuteNonQuery();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LTeachers_Click(object sender, EventArgs e)
        {

        }

        private void CBSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection == null)
                return;
            LBTeachers.Items.Clear();
            LBStudents.Items.Clear();
            CBClass.Items.Clear();
            Database.GetClasses(CBSchool.SelectedItem.ToString()).ForEach(classdesc =>
            {
                CBClass.Items.Add(classdesc);   
            });
        }

        private void ResetSchoolItems()
        {
            if (connection == null)
                return;
            CBSchool.Items.Clear();
            Database.GetSchools().ForEach(schooldesc =>
            {
                CBSchool.Items.Add(schooldesc);
            });
        }

        private void TBStudents_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connection == null)
                return;
            LBStudents.Items.Clear();  
            Database.GetStudents(CBSchool.SelectedItem.ToString(), CBClass.SelectedItem.ToString()).ForEach(student =>
            {
                LBStudents.Items.Add(student);
            });
            LBTeachers.Items.Clear();
            Database.GetTeachers(CBSchool.SelectedItem.ToString(), CBClass.SelectedItem.ToString()).ForEach(teacher =>
            {
                LBTeachers.Items.Add(teacher);
            });
        }

        private void DisableAll()
        {
            MIImport.Enabled = false;
            MIPrint.Enabled = false;
            CBSchool.Enabled = false;
            CBClass.Enabled = false;
            LBStudents.Enabled = false;
            LBTeachers.Enabled = false;
        }

        private void EnableAll()
        {
            MIImport.Enabled = true;
            MIPrint.Enabled = true;
            CBSchool.Enabled = true;
            CBClass.Enabled = true;
            LBStudents.Enabled = true;
            LBTeachers.Enabled = true;
        }

        private void ClearAll()
        {
            CBSchool.Items.Clear();
            CBClass.Items.Clear();
            LBStudents.Items.Clear();
            LBTeachers.Items.Clear();
        }

        private void MIPrint_Click(object sender, EventArgs e)
        {
            if (CBSchool.SelectedItem == null || CBClass.SelectedItem == null)
                return;

            PPD.ShowDialog();
        }

        private void PDoc_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            page = 0;
            lines = new List<string>();

            lines.Add("School: " + CBSchool.SelectedItem.ToString());
            lines.Add("Class: " + CBClass.SelectedItem.ToString());
            lines.Add("Students:");
            foreach(object o in LBStudents.Items)
            {
                lines.Add(o.ToString());
            }
            lines.Add("Teachers:");
            foreach(object o in LBTeachers.Items)
            {
                lines.Add(o.ToString());
            }
        }

        private void PDoc_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void PDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int ypos = B_TOP;

            Graphics g = e.Graphics;
            heightFont = (int)g.MeasureString("Äq", f).Width;

            int counter = 0;
            foreach(string line in lines)
            {
                g.DrawString(line, f, Brushes.Black, B_LEFT, ypos);
                ypos += heightFont + linespace;
                counter++;

                if (ypos > B_BOTTOM)
                {
                    e.HasMorePages = true;
                    break;
                }
                else
                    e.HasMorePages = false;
            };

            lines.RemoveRange(0, counter);

            g.DrawString("Seite " + page,
                         f, Brushes.Black,
                         B_LEFT + (B_RIGHT - B_LEFT) / 2 - (int)g.MeasureString("Seite " + page, f).Width,
                         B_BOTTOM + linespace);
        }

        private void PDoc_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {
            page++;
        }
    }
}
