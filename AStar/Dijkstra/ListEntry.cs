using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class ListEntry
    {
        public Node N { set; get; }
        public int Distance { set; get; }
        public double S { set; get; }
        public Node Predecessor { set; get; }

        public ListEntry(Node n, int distance, double s,  Node predecessor)
        {
            N = n;
            Distance = distance;
            S = s;
            Predecessor = predecessor;
        }
    }
}
