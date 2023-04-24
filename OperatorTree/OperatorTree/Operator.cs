using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTree
{
    [Serializable]
    class Operator : Node
    {
        public string Op { set; get; }
        public Node Left { set; get; }
        public Node Right { set; get; }

        public Operator(int x, int y, string op) : base(x, y)
        {
            Op = op;
        }

        override public bool InNode(int x, int y)
        {
            return (x > X - SIZE && x < X + SIZE && y > Y - SIZE && y < Y + SIZE);
        }

        override public void DrawNodes(Graphics g)
        {
            g.FillRectangle(Brushes.White, X - SIZE, Y - SIZE, SIZE * 2, SIZE * 2);
            g.DrawRectangle(Pens.Black, X - SIZE, Y - SIZE, SIZE * 2, SIZE * 2);
            SizeF ssize = g.MeasureString(Op, FONT);
            g.DrawString(Op, FONT, Brushes.Black, X - ssize.Width / 2, Y - ssize.Height / 2);
        }

        override public void DrawConnections(Graphics g)
        {
            if (Left != null)
                g.DrawLine(Pens.Black, X, Y, Left.X, Left.Y);
            if (Right != null)
                g.DrawLine(Pens.Black, X, Y, Right.X, Right.Y);
        }
    }
}
