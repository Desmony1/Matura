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
        public FMain()
        {
            InitializeComponent();
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
            }
        }

        private void MIExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MIImport_Click(object sender, EventArgs e)
        {
            if(connection == null)
            {
                MessageBox.Show("There is no connection to the database!");
                return;
            }
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                Directory.EnumerateDirectories(fbd.SelectedPath).ToList().ForEach(directory =>
                {
                    String school = directory.Substring(directory.LastIndexOf("\\")+1);
                    
                });
            }
        }
    }
}
