using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class ClosedList
    {
        private Dictionary<Node, ListEntry> closedDictionary = new Dictionary<Node, ListEntry>();

        public void AddEntry(ListEntry entry)
        {
            if (closedDictionary.ContainsKey(entry.n))
                return;
            closedDictionary.Add(entry.n, entry);
        }

        public List<Node> GetPath(Node endNode)
        {
           ListEntry tmp = closedDictionary[endNode];
           List<Node> result = new List<Node>();
            while (true)
            {
                result.Add(tmp.n);
                if (tmp.predecessor == null)
                    break;
                tmp = closedDictionary[tmp.predecessor];
            }
            return result;
        }

        public bool IsInClosed(Node n)
        {
            return closedDictionary.ContainsKey(n);
        }
    }
}
