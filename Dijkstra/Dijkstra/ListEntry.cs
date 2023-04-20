using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class ListEntry
    {
        public Node n;
        public int distance;
        public Node predecessor;

        public ListEntry(Node n, int distance, Node predecessor)
        {
            this.n = n;
            this.distance = distance;
            this.predecessor = predecessor;
        }
    }
}
