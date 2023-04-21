using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

namespace Dijkstra
{
    public partial class FMain : Form
    {
        public FMain()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de");
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        }

        private NodeManagement nm = new NodeManagement();
        private Node currNode;
        private Node ctxNode;
        private int x, y, beforex, beforey;
        private bool connecting;

        private void FMain_MouseUp(object sender, MouseEventArgs e)
        {
            Node tmp = nm.InNode(e.X, e.Y);

            if(currNode == null && !nm.NearNode(e.X, e.Y) && e.Button.HasFlag(MouseButtons.Left))
                nm.AddNode(e.X, e.Y);
            else if(currNode != null && tmp != null && e.Button.HasFlag(MouseButtons.Left))
            {
                nm.AddNeighbour(currNode, tmp);
                nm.Search();
            }else if(tmp != null && e.Button.HasFlag(MouseButtons.Right))
            {
                CMSmain.Show(this, e.X, e.Y);
                ctxNode = tmp;
            }
            currNode = null;
            connecting = false;
            Refresh();
        }

        private void FMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (currNode != null && connecting)
                g.DrawLine(Pens.Black, currNode.X, currNode.Y, x, y);
            nm.PaintNodes(g);

        }

        private void FMain_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            if (currNode!= null && ModifierKeys.HasFlag(Keys.Control))
            {
                currNode.MoveNode(x-beforex, y-beforey);
                beforex = x;
                beforey = y;
            }
            Refresh();
        }

        private void MIstart_Click(object sender, EventArgs e)
        {
            if(ctxNode != null && ctxNode != nm.EndNode)
            {
                nm.StartNode = ctxNode;
                nm.Search();
            }

            Refresh();
        }

        private void MIend_Click(object sender, EventArgs e)
        {
            if (ctxNode != null && ctxNode != nm.StartNode)
            {
                nm.EndNode = ctxNode;
                nm.Search();
            }           
            Refresh();
        }

        private void MIdelete_Click(object sender, EventArgs e)
        {
            if (ctxNode != null)
            {
                nm.RemoveNode(ctxNode);
                nm.ResetMarked();
                nm.Search();
            }
                
            Refresh();
        }

        private void MIExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MINew_Click(object sender, EventArgs e)
        {
            nm = new NodeManagement();
            Refresh();
        }

        private void MIOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Graph-Dateien(*.grp)|*.grp";
            ofd.InitialDirectory = "C:\\temp";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                nm = (NodeManagement)bf.Deserialize(fs);
                Refresh();
            }
        }

        private void MISave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Graph-Dateien(*.grp)|*.grp";
            sfd.InitialDirectory = "C:\\temp";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, nm);
            }

        }

        private void FMain_Load(object sender, EventArgs e)
        {

        }

        private void MIPrint_Click(object sender, EventArgs e)
        {
            if (ctxNode != null)
            {
                Console.Write("(");
                ctxNode.neighbours.ForEach(node => Console.Write(node.Id + ";"));
                Console.Write(")");
            }
        }

        private void MIGerman_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("de");
            Controls.Clear();
            InitializeComponent();
        }

        private void MIEnglish_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
            Controls.Clear();
            InitializeComponent();
        }

        private void MSmain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MIAnimation_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ParameterizedThreadStart(nm.SearchAnimation));
            t.Start(this);
        }

        private void FMain_MouseDown(object sender, MouseEventArgs e)
        {
            currNode = nm.InNode(e.X, e.Y);
            beforex = e.X;
            beforey = e.Y;
            if (e.Button.HasFlag(MouseButtons.Left) && !ModifierKeys.HasFlag(Keys.Control))
                connecting = true;
        }
    }
}
