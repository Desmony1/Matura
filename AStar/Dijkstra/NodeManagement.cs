using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    [Serializable]
    internal class NodeManagement
    {
        List<Node> nodes = new List<Node>();
        private int counter = 0;
        private Node startNode, endNode;

        public Node StartNode
        {
            get{return startNode;}
            set
            {
                if (startNode != null)
                {
                    startNode.Color = Color.Black;
                }
                startNode = value;
                startNode.Color = Color.Red;
            }
           
        }

        public Node EndNode
        {
            set
            {
                if (endNode != null)
                {
                    endNode.Color = Color.Black;
                }
                endNode = value;
                endNode.Color = Color.Red;
            }
            get
            {
                return endNode;
            }
        }

        public void AddNode(int x, int y)
        {
            nodes.Add(new Node(++counter, x, y, Color.Black));
        }

        public void PaintNodes(Graphics g)
        {
            nodes.ForEach(node => node.PaintNeighbours(g));
            nodes.ForEach(node => node.PaintNode(g));
        }

        public Node InNode(int x, int y)
        {
            Node n = null;
            nodes.ForEach(node =>
            {
                if (node.InNode(x, y))
                    n = node;
            });
            return n;
        }

        public bool NearNode(int x, int y)
        {
            Boolean result = false;
            nodes.ForEach(node =>
            {
                if (node.InNode(x, y, 20))
                    result = true;
            });
            return result;
        }

        public bool AddNeighbour(Node n1, Node n2)
        {
            if (n1.ContainsNeighbour(n2) && n2.ContainsNeighbour(n1))
                return false;

            n1.AddNeighbour(n2);
            n2.AddNeighbour(n1);
            return true;
        }

        public void RemoveNode(Node n)
        {
            n.RemoveFromNeighbours();
            nodes.Remove(n);
        }

        public void ResetMarked()
        {
            nodes.ForEach(node => node.Color = Color.Black);
        }

        public void Search()
        {
            if (StartNode == null || EndNode == null)
                return;

            ResetMarked();
            OpenList openList = new OpenList();
            ClosedList closedList = new ClosedList();

            ListEntry entry = new ListEntry(StartNode, 0, StartNode.Heuristic(EndNode), null);

            while(entry != null)
            {
                if (entry.n == EndNode)
                    break;
                entry.n.neighbours.ForEach(node =>
                {
                    if (closedList.IsInClosed(node))
                    {

                    } else if (!openList.IsInOpen(node))
                    {
                        openList.AddEntry(new ListEntry(node, entry.distance + 1, entry.n));
                    }
                    else
                    {
                        ListEntry entry2 = openList.Get(node);
                        if (entry2.distance > entry.distance)
                        {
                            entry2.distance = entry.distance + 1;
                            entry2.predecessor = entry.n;
                        }
                    }
                });
                closedList.AddEntry(entry);
                entry = openList.GetBest();
            }
            if (entry != null)
                closedList.AddEntry(entry);
            else
            {
                StartNode.Color = Color.Red;
                EndNode.Color = Color.Red;
                return;
            }


            List<Node> nodelist = closedList.GetPath(EndNode);

            nodelist.ForEach(node => Console.Write(node.Id+"->"));
            nodelist.ForEach(node => node.Color = Color.Red);
        }

        public void SearchAnimation(Object f)
        {
            if (StartNode == null || EndNode == null)
                return;


            FMain frame = (FMain)f;
            Console.WriteLine("Animation");
            ResetMarked();
            OpenList openList = new OpenList();
            ClosedList closedList = new ClosedList();

            StartNode.Color = Color.Blue;
            EndNode.Color = Color.Blue;

            ListEntry entry = new ListEntry(StartNode, 0, null);

            while (entry != null)
            {
                if(entry.n != StartNode)
                    entry.n.Color = Color.Orange;
                frame.Invalidate();
                Thread.Sleep(2000);
                if (entry.n == EndNode)
                    break;
                entry.n.neighbours.ForEach(node =>
                {
                    if (closedList.IsInClosed(node))
                    {

                    }
                    else if (!openList.IsInOpen(node))
                    {
                        openList.AddEntry(new ListEntry(node, entry.distance + 1, entry.n));
                    }
                    else
                    {
                        ListEntry entry2 = openList.Get(node);
                        if (entry2.distance > entry.distance)
                        {
                            entry2.distance = entry.distance + 1;
                            entry2.predecessor = entry.n;
                        }
                    }
                });
                closedList.AddEntry(entry);
                entry = openList.GetBest();

            }
            if (entry != null)
            {
                closedList.AddEntry(entry);
            }
            else
            {
                StartNode.Color = Color.Red;
                EndNode.Color = Color.Red;
                return;
            }


            List<Node> nodelist = closedList.GetPath(EndNode);

            ResetMarked();
            nodelist.ForEach(node => Console.Write(node.Id + "->"));
            nodelist.ForEach(node => node.Color = Color.Red);
            frame.Invalidate();
        }
    }
}
