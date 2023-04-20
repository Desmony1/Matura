using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class NodeManagement
    {
        List<Node> nodes = new List<Node>();
        private Node startNode, endNode;

        public Node StartNode
        {
            get{return startNode;}
            set
            {
                if (startNode != null)
                {
                    startNode.Marked = false;
                }
                startNode = value;
                startNode.Marked = true;
            }
           
        }

        public Node EndNode
        {
            set
            {
                if (endNode != null)
                {
                    endNode.Marked = false;
                }
                endNode = value;
                endNode.Marked = true;
            }
            get
            {
                return endNode;
            }
        }



        public void AddNode(int x, int y)
        {
            nodes.Add(new Node(nodes.Count(), x, y));
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

        public void Search()
        {
            OpenList openList = new OpenList();
            ClosedList closedList = new ClosedList();  


        }
    }
}
