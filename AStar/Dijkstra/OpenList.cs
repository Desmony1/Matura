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
            if (openList.Contains(entry) || openDictionary.ContainsKey(entry.N))
                return;

            openList.Add(entry);
            openDictionary.Add(entry.N, entry);
        }

        public ListEntry GetBest()
        {
            if (openList.Count == 0)
                return null;
            openList.Sort((e1, e2) => (e1.Distance + e1.S).CompareTo(e2.Distance + e2.S));
            ListEntry best = openList[0];
            openList.RemoveAt(0);
            openDictionary.Remove(best.N);
            return best;
        }

        public ListEntry Get(Node n)
        {
            if (IsInOpen(n))
                return openDictionary[n];
            return null;
        }

        public bool IsInOpen(Node n)
        {
            return openDictionary.ContainsKey(n);
        }

        public void Print()
        {
            Console.WriteLine("Print Openlist");
            openList.ForEach(entry =>
            {
                Console.WriteLine("Knoten: " + entry.N.Id+ " Distanz: " + entry.Distance + " Schätzfunktion: " + entry.S + " Vorgänger: " + entry.Predecessor.Id);
            });
        }
    }
}
