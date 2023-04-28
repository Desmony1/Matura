using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace OperatorTree
{
    public partial class FMain : Form
    {
        Tree t = new Tree();
        private Node movingNode, connectingNode;
        private int currentX, currentY;
        private AnimationDialog ad = new AnimationDialog();
        public Thread th;
        public Node redNode;
        public readonly static int SIZE = 20;
        public FMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void FMain_Paint(object sender, PaintEventArgs e)
        {
            if(connectingNode != null)
            {
                e.Graphics.DrawLine(Pens.Black, connectingNode.X, connectingNode.Y, currentX, currentY);
            }
            t.DrawNodes(e.Graphics);
            if(redNode != null)
            {
                if(redNode is Operator)
                {
                    e.Graphics.DrawRectangle(Pens.Red, redNode.X - SIZE, redNode.Y - SIZE, SIZE * 2, SIZE * 2);
                }
                else
                {
                    e.Graphics.DrawEllipse(Pens.Red, redNode.X - SIZE, redNode.Y - SIZE, SIZE * 2, SIZE * 2);
                }
            }
            if (t.IsValid())
            {
                miAnimation.Enabled = true;
                lValidation.Text = "Valid";
                lValidation.ForeColor = Color.Green;
                t.Infix = "";
                t.Prefix = "";
                t.Postfix = "";
                t.GetPostfix(t.startNode);
                t.GetPrefix(t.startNode);
                t.GetInfix(t.startNode);
                lPostfix.Text = "Postfix: " + t.Postfix;
                lPrefix.Text = "Prefix: " + t.Prefix;
                lInfix.Text = "Infix: " + t.Infix;
            }
            else
            {
                miAnimation.Enabled = false;
                lValidation.Text = "Not Valid";
                lValidation.ForeColor = Color.Red;
                lInfix.Text = "infix";
                lPostfix.Text = "postfix";
                lPrefix.Text = "prefix";
            }
        }

        private void FMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (t.IsInNode(e.X, e.Y) == null)
                {
                    MSAdd.Show(this, e.X, e.Y);
                    currentX = e.X;
                    currentY = e.Y;
                }
            }else if(e.Button == MouseButtons.Left && ModifierKeys.HasFlag(Keys.Control))
            {
                if (t.IsInNode(e.X, e.Y) != null)
                {
                    movingNode = t.IsInNode(e.X, e.Y);
                }
            }
            else if(e.Button == MouseButtons.Left)
            {
                if (t.IsInNode(e.X, e.Y) != null)
                {
                    connectingNode = t.IsInNode(e.X, e.Y);
                }
            }
        }

        private void FMain_Load(object sender, EventArgs e)
        {
        }

        private void operandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperandDialog opd = new OperandDialog();
            if(opd.ShowDialog() == DialogResult.OK)
            {
                t.AddNode(new Operand(currentX, currentY, opd.Number));
                Refresh();
            }
        }

        private void FMain_MouseMove(object sender, MouseEventArgs e)
        {
            if(movingNode != null)
            {
                movingNode.X = e.X;
                movingNode.Y = e.Y;
            }else if(connectingNode != null)
            {
                currentX = e.X;
                currentY = e.Y;
            }
            Refresh();
        }

        private void FMain_MouseUp(object sender, MouseEventArgs e)
        {
            Node tmp = t.IsInNode(e.X, e.Y);
            if(connectingNode != null && tmp != null && connectingNode is Operator)
            {
                Operator n = (Operator)connectingNode;
                if(n.Left == null || n.Right == null)
                {
                    if (tmp.Y > connectingNode.Y)
                    {
                        tmp.Parent = connectingNode;
                        if (n.Left == null && tmp.X < connectingNode.X)
                        {
                            n.Left = tmp;
                        }
                        else if (n.Right == null)
                        {
                            n.Right = tmp;
                        }
                    }
                }          
            }
            movingNode = null;
            connectingNode = null;
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            t = new Tree();
            Refresh();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.InitialDirectory = @"C:\Temp";
            opd.Filter = "Operator Trees (*.ot)|*.ot";
            opd.CheckFileExists = true;
            opd.CheckPathExists = true;
            if(opd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.Open(opd.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                t = (Tree)(bf.Deserialize(fs));
                Refresh();
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\Temp";
            sfd.Filter = "Operator Trees (*.ot)|*.ot";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = File.OpenWrite(sfd.FileName);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, t);
                Refresh();
            }
        }

        private void miAnimation_Click(object sender, EventArgs e)
        {        
            if (miAnimation.Checked)
            {
                ad = new AnimationDialog();
                ad.StartPosition = FormStartPosition.Manual;
                ad.SetDesktopLocation(this.Location.X + this.Width, this.Location.Y + this.Height/3);
                ad.animation += new startAnimation(StartAnimation);
                ad.Show();
            }
            else
            {
                ad.Close();
            }
        }

        public void StartAnimation(String notation)
        {
            th = new Thread(new ThreadStart(() => Animation(t.startNode, notation)));
            th.Start();
        }

        private void FMain_LocationChanged(object sender, EventArgs e)
        {
            ad.SetDesktopLocation(this.Location.X + this.Width, this.Location.Y + this.Height/3);
        }

        private void FMain_Resize(object sender, EventArgs e)
        {
            ad.SetDesktopLocation(this.Location.X + this.Width, this.Location.Y + this.Height / 3);
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void operatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorDialog opd = new OperatorDialog();
            if(opd.ShowDialog() == DialogResult.OK)
            {
                t.AddNode(new Operator(currentX, currentY, opd.OperatorC));
                Refresh();
            }
        }
        
        public void Animation(Node n, String not)
        {
            if (not == "infix")
            {
                redNode = n;
                if (n == null)
                {
                    return;
                }

                if (n is Operator)
                {
                    Animation(((Operator)n).Left, not);
                    redNode = n;
                    Invalidate();
                    Thread.Sleep(1000);
                    Animation(((Operator)n).Right, not);
                }
                Invalidate();
                Thread.Sleep(1000);
            }
            if (not == "prefix")
            {
                redNode = n;
                if (n == null)
                {
                    return;
                }

                if (n is Operator)
                {
                    redNode = n;
                    Invalidate();
                    Thread.Sleep(1000);
                    Animation(((Operator)n).Left, not);
                    Animation(((Operator)n).Right, not);
                }
                Invalidate();
                Thread.Sleep(1000);
            }
            if (not == "postfix")
            {
                redNode = n;
                if (n == null)
                {
                    return;
                }

                if (n is Operator)
                {
                    Animation(((Operator)n).Left, not);
                    Animation(((Operator)n).Right, not);
                    redNode = n;
                    Invalidate();
                    Thread.Sleep(1000);                  
                }
                Invalidate();
                Thread.Sleep(1000);
            }
            redNode = null;
        }
    }
}
