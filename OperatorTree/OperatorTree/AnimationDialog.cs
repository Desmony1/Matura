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

    public delegate void startAnimation(String notation);
    public partial class AnimationDialog : Form
    {
        public event startAnimation animation;

        public AnimationDialog()
        {
            InitializeComponent();
        }

        private void AnimationDialog_Load(object sender, EventArgs e)
        {

        }

        private void bRun_Click(object sender, EventArgs e)
        {
            if (rbInfix.Checked)
                animation(rbInfix.Text);
            else if (rbPostfix.Checked)
                animation(rbPostfix.Text);
            else if (rbPrefix.Checked)
                animation(rbPrefix.Text);
        }

        private void gbAnimation_Enter(object sender, EventArgs e)
        {

        }
    }
}
