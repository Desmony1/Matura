using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTree
{
    [Serializable]
    class Operand : Node
    {
        public int Number { set; get; }

        public Operand (int x, int y, int number) : base(x, y)
        {
            Number = number;
        }

        override public bool InNode(int x, int y)
        {
            int dx = X - x;
            int dy = Y - y;
            return Math.Sqrt(dy * dy + dx * dx) < SIZE;
        }

         override public void DrawNodes(Graphics g)
        {
            g.FillEllipse(Brushes.White, X - SIZE, Y - SIZE, SIZE * 2, SIZE * 2);
            g.DrawEllipse(Pens.Black, X - SIZE, Y - SIZE, SIZE * 2, SIZE * 2);
            SizeF ssize = g.MeasureString(Number.ToString(), FONT);
            g.DrawString(Number.ToString(), FONT, Brushes.Black, X - ssize.Width / 2, Y - ssize.Height / 2);
        }

        public override void DrawConnections(Graphics g)
        {
            return;
        }
    }
}
