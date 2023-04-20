using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private NodeManagement nm = new NodeManagement();
        private Node currNode;
        private Node ctxNode;
        private int x, y;

        private void FMain_MouseUp(object sender, MouseEventArgs e)
        {
            Node tmp = nm.InNode(e.X, e.Y);

            if(currNode == null && !nm.NearNode(e.X, e.Y) && e.Button.HasFlag(MouseButtons.Left))
                nm.AddNode(e.X, e.Y);
            else if(currNode != null && tmp != null && e.Button.HasFlag(MouseButtons.Left))
            {
                nm.AddNeighbour(currNode, tmp);
            }else if(tmp != null && e.Button.HasFlag(MouseButtons.Right))
            {
                CMSmain.Show(this, e.X, e.Y);
                ctxNode = tmp;
            }
            currNode = null;
            Refresh();
        }

        private void FMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (currNode != null)
                g.DrawLine(Pens.Black, currNode.X, currNode.Y, x, y);
            nm.PaintNodes(g);

        }

        private void FMain_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            if (currNode!= null && ModifierKeys.HasFlag(Keys.Control))
            {
                currNode.MoveNode(x, y);
            }
            Refresh();
        }

        private void MIstart_Click(object sender, EventArgs e)
        {
            if(ctxNode != null && ctxNode != nm.EndNode)
                nm.StartNode = ctxNode;
            Refresh();
        }

        private void MIend_Click(object sender, EventArgs e)
        {
            if (ctxNode != null && ctxNode != nm.StartNode)
                nm.EndNode = ctxNode;
            Refresh();
        }

        private void FMain_MouseDown(object sender, MouseEventArgs e)
        {
            currNode = nm.InNode(e.X, e.Y);
        }
    }
}
