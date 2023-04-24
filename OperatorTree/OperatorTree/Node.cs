using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTree
{
    [Serializable]
    public abstract class Node
    {
        public int X { set; get; }
        public int Y { set; get; }
        public Node Parent { set; get; }

        [NonSerialized]public readonly static int SIZE = 20;

        [NonSerialized]public readonly static Font FONT = new Font("Arial", 10);


        public Node(int x, int y)
        {
            X = x;
            Y = y;
        }


        public abstract bool InNode(int x, int y);
        public abstract void DrawNodes(Graphics g);

        public abstract void DrawConnections(Graphics g);


    }
}
