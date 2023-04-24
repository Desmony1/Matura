using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorTree
{
    public partial class OperandDialog : Form
    {
        public int Number { private set; get; }
        public OperandDialog()
        {
            InitializeComponent();
        }

        private void OperandDialog_Load(object sender, EventArgs e)
        {

        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^\d*$");
            if (tbNumber.Text != "" && rx.IsMatch(tbNumber.Text))
            {
                bAccept.Enabled = true;
                Number = int.Parse(tbNumber.Text);
            }
            else
                bAccept.Enabled = false;
        }
    }
}
