using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    [Serializable]
    internal class Node
    {
        public int Id { set; get; }
        public int X { set; get; }
        public int Y { set; get; }
        public Color Color { set; get; }

        public Dictionary<Node, int> neighbours = new Dictionary<Node, int>();

        public Node(int id, int x, int y, Color c)
        {
            Id = id;
            X = x;
            Y = y;
            Color = c;
        }
        
        public const int SIZE = 20;
        private readonly Font FONT = new Font("Arial", 10);

        public void PaintNode(Graphics g)
        {
            Pen pen = new Pen(Color);
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(Brushes.White, X - SIZE, Y - SIZE, SIZE * 2, SIZE * 2);
            g.DrawEllipse(pen, X-SIZE, Y-SIZE, SIZE * 2, SIZE * 2);
            SizeF size = g.MeasureString(Id.ToString(), FONT);
            g.DrawString(Id.ToString(), FONT, brush, X-(size.Width/2), Y-(size.Height/2));
        }

        public void PaintNeighbours(Graphics g)
        {
            neighbours.Keys.ToList().ForEach(node => {
                if(this.Id < node.Id)
                {
                    SizeF size = g.MeasureString(neighbours[node].ToString(), FONT);
                    g.DrawString(neighbours[node].ToString(), FONT, Brushes.Black, (this.X + node.X) / 2, (this.Y + node.Y) / 2);
                    if (node.Color != Color.Black && this.Color != Color.Black && node.Color != Color.Orange && node.Color != Color.Blue)
                        g.DrawLine(new Pen(this.Color), X, Y, node.X, node.Y);
                    else
                        g.DrawLine(new Pen(Color.Black), X, Y, node.X, node.Y);
                }
            });
        }
        public bool InNode(int x, int y, int size = 0)
        {
            int dx = X - x;
            int dy = Y - y;
            return Math.Sqrt(dx*dx+dy*dy) < SIZE+size;
        }

        public void AddNeighbour(Node n, int distance)
        {
            if(n != this)
                neighbours.Add(n, distance);
        }

        public void RemoveFromNeighbours()
        {
            neighbours.Keys.ToList().ForEach(node => node.neighbours.Remove(this));
        }

        public bool ContainsNeighbour(Node n)
        {
            return neighbours.ContainsKey(n);
        }

        public int GetDistanceTo(Node n)
        {
            return neighbours[n];
        }

        public void MoveNode(int x, int y)
        {
            X += x;
            Y += y;
        }

        public void UpdateDistances()
        {
            neighbours.Keys.ToList().ForEach(node =>
            {
                neighbours[node] = Heuristic(node);
                node.neighbours[this] = Heuristic(node);
            });
        }

        public int Heuristic(Node n)
        {
            int dx = X - n.X;
            int dy = Y - n.Y;
            return (int)Math.Sqrt(dx * dx + dy * dy);
        }

    }
}
