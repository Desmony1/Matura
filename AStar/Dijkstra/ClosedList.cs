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
            if (closedDictionary.ContainsKey(entry.N))
                return;
            closedDictionary.Add(entry.N, entry);
        }

        public List<Node> GetPath(Node endNode)
        {
           ListEntry tmp = closedDictionary[endNode];
           List<Node> result = new List<Node>();
            while (true)
            {
                result.Add(tmp.N);
                if (tmp.Predecessor == null)
                    break;
                tmp = closedDictionary[tmp.Predecessor];
            }
            return result;
        }

        public int GetPathTotal(Node endNode)
        {
            return closedDictionary[endNode].Distance;
        }
        public bool IsInClosed(Node n)
        {
            return closedDictionary.ContainsKey(n);
        }
    }
}
