using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    internal class OpenList
    {
        private List<ListEntry> openList = new List<ListEntry>();
        private Dictionary<Node, ListEntry> openDictionary = new Dictionary<Node, ListEntry>();

        public void AddEntry(ListEntry entry)
        {
            if (openList.Contains(entry) || openDictionary.ContainsKey(entry.n))
                return;

            openList.Add(entry);
            openDictionary.Add(entry.n, entry);
        }

        public void Sort()
        {
            openList.Sort((e1, e2) => e1.distance.CompareTo(e2.distance));
        }

        public ListEntry GetBest()
        {
            if (openList.Count == 0)
                return null;
            ListEntry best = openList[0];
            openList.RemoveAt(0);
            openDictionary.Remove(best.n);
            return best;
        }
    }
}
