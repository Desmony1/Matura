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

        public List<Node> GetPath()
        {
            return closedDictionary.Keys.ToList();
        }
    }
}
