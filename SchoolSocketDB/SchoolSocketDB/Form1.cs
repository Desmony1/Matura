using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSocketDB
{
    public partial class FMain : Form
    {
        Socket socket = null; 

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
        }

        private void FMain_Load(object sender, EventArgs e)
        {
        }

        private void MIConnect_Click(object sender, EventArgs e)
        {
            if (!MIConnect.Checked)
            {
                
                try
                {
                    IPEndPoint localEndPoint = new IPEndPoint(new IPAddress(new byte[] { 127, 0, 0, 1 }), 11111);
                    socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(localEndPoint);
                    MessageBox.Show("Successfully connected to the server!");
                    MIDisconnect.Checked = false;
                    MIConnect.Checked = true;
                    EnableAll();
                    ResetSchoolItems();
                }catch(Exception ex)
                {
                    MessageBox.Show("Error while connecting to the server! Error: "+ex.Message);
                }      
            }
        }

        private void MIDisconnect_Click(object sender, EventArgs e)
        {
            if (!MIDisconnect.Checked)
            {
                MIConnect.Checked = false;
                MIDisconnect.Checked = true;
                socket.Send(Encoding.ASCII.GetBytes("disconnect"));
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                socket = null;
                MessageBox.Show("Successfully disconnected from the server!");
                DisableAll();
                ClearAll();
            }
        }

        private void MIExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LTeachers_Click(object sender, EventArgs e)
        {

        }

        private void CBSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (socket == null)
                return;
            LBTeachers.Items.Clear();
            LBStudents.Items.Clear();
            CBClass.Items.Clear();
            socket.Send(Encoding.ASCII.GetBytes("GetClasses Parameter:"+CBSchool.SelectedItem.ToString()));

            byte[] bytesReceived = new Byte[1024];
            int numBytesReceived = socket.Receive(bytesReceived);

            string response = Encoding.ASCII.GetString(bytesReceived, 0, numBytesReceived);

            string[] classes = response.Split(',');


            classes.ToList().ForEach(classdesc =>
            {
                CBClass.Items.Add(classdesc);   
            });
        }

        private void ResetSchoolItems()
        {
            if (socket == null)
                return;
            CBSchool.Items.Clear();
            socket.Send(Encoding.ASCII.GetBytes("GetSchools"));
            byte[] bytesReceived = new Byte[1024];
            int numBytesReceived = socket.Receive(bytesReceived);

            string response = Encoding.ASCII.GetString(bytesReceived, 0, numBytesReceived);
            Console.WriteLine(response);

            string[] schools = response.Split(',');
            schools.ToList().ForEach(schooldesc =>
            {
                CBSchool.Items.Add(schooldesc);
            });
        }

        private void TBStudents_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (socket == null)
                return;
            LBStudents.Items.Clear();
            socket.Send(Encoding.ASCII.GetBytes("GetStudents Parameter:" + CBSchool.SelectedItem.ToString()+","+CBClass.SelectedItem.ToString()));

            byte[] bytesReceived = new Byte[1024];
            int numBytesReceived = socket.Receive(bytesReceived);

            string response = Encoding.ASCII.GetString(bytesReceived, 0, numBytesReceived);

            string[] students = response.Split(',');
            students.ToList().ForEach(student =>
            {
                LBStudents.Items.Add(student);
            });
            LBTeachers.Items.Clear();

            socket.Send(Encoding.ASCII.GetBytes("GetTeachers Parameter:" + CBSchool.SelectedItem.ToString() + "," + CBClass.SelectedItem.ToString()));

            bytesReceived = new Byte[1024];
            numBytesReceived = socket.Receive(bytesReceived);

            response = Encoding.ASCII.GetString(bytesReceived, 0, numBytesReceived);

            string[] teachers = response.Split(',');
            teachers.ToList().ForEach(teacher =>
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

        private void MIImport_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = "C:\\temp\\SchoolDB\\";
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                socket.Send(Encoding.ASCII.GetBytes("import Parameter:"+fbd.SelectedPath));
                ResetSchoolItems();
            }
        }

        private void MSMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
