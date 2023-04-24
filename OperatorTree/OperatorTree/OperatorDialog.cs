using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorTree
{
    public partial class OperatorDialog : Form
    {
        public string OperatorC { set; get;}
        public OperatorDialog()
        {
            InitializeComponent();
        }

        private void cbOperator_SelectedValueChanged(object sender, EventArgs e)
        {
            bAccept.Enabled = true;
            OperatorC = this.cbOperator.SelectedItem.ToString();
        }

        private void OperatorDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
