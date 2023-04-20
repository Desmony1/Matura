using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class Node
    {
        public int Id { set; get; }
        public int X { set; get; }
        public int Y { set; get; }
        public bool Marked { set; get; }

        private List<Node> neighbours = new List<Node>();

        public Node(int id, int x, int y)
        {
            Id = id;
            X = x;
            Y = y;
        }

        public const int SIZE = 20;
        private readonly Font FONT = new Font("Arial", 10);

        public void PaintNode(Graphics g)
        {
            Pen pen = Pens.Black;
            Brush brush = Brushes.Black;
            if (Marked)
            {
                pen = Pens.Red;
                brush = Brushes.Red;
            }
            g.FillEllipse(Brushes.White, X - SIZE, Y - SIZE, SIZE * 2, SIZE * 2);
            g.DrawEllipse(pen, X-SIZE, Y-SIZE, SIZE * 2, SIZE * 2);
            SizeF size = g.MeasureString(Id.ToString(), FONT);
            g.DrawString(Id.ToString(), FONT, brush, X-(size.Width/2), Y-(size.Height/2));
        }

        public void PaintNeighbours(Graphics g)
        {
            neighbours.ForEach(node => g.DrawLine(Pens.Black, X, Y, node.X, node.Y));
        }
        public bool InNode(int x, int y, int size = 0)
        {
            int dx = X - x;
            int dy = Y - y;
            return Math.Sqrt(dx*dx+dy*dy) < SIZE+size;
        }

        public void AddNeighbour(Node n)
        {
            neighbours.Add(n);
        }

        public bool ContainsNeighbour(Node n)
        {
            return neighbours.Contains(n);
        }

        public void MoveNode(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
