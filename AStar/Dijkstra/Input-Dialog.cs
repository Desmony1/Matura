using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AStar
{

    public partial class FDialog : Form
    {
        public int Input { get; private set; }



        public FDialog(String mode)
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FDialog_Load(object sender, EventArgs e)
        {

        }

        private void BOk_Click(object sender, EventArgs e)
        {
            try
            {
                String value = TBInput.Text;
                Input = int.Parse(value);
                DialogResult = DialogResult.OK;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult=DialogResult.Abort;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
