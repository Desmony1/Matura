using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTree
{   
    [Serializable]
    class Tree
    {
        private List<Node> nodes = new List<Node>();
        public Node startNode;
        public string Infix { set; get; }
        public string Prefix { set; get; }
        public string Postfix { set; get; }


        public void AddNode(Node n)
        {
            nodes.Add(n);
            if(startNode == null || startNode.Y > n.Y)
            {
                startNode = n;
            }
        }

        public void DrawNodes(Graphics g)
        {
            nodes.ForEach(n => { { n.DrawConnections(g); } });
            nodes.ForEach(n => { n.DrawNodes(g); });
        }

        public bool IsValid()
        {
            if(nodes.Count == 0)
                return false;
            Boolean result = true;
            nodes.ForEach(n => { if (n is Operator) { Operator node = (Operator)n; if (node.Left == null || node.Right == null) { result = false; } } });
            int count = 0;
            nodes.ForEach(n => { if (n.Parent == null) { count++; };});
            if(count != 1){
                result = false;
            }
            return result;
        }
        public void GetInfix(Node n)
        {
            if (n == null)
            {
                return;
            }

            if (n is Operator)
            {
                Infix += "(";
            }

            if (n is Operator) {
                GetInfix(((Operator)n).Left);
                Infix += ((Operator)n).Op;
                GetInfix(((Operator)n).Right);
            }
            if (n is Operand)
                Infix += ((Operand)n).Number.ToString();
            

            if (n is Operator)
            {
                Infix += ")";
            }
        }
        
        public void GetPrefix(Node n)
        {
            if (n == null)
            {
                return;
            }
            
            if(n is Operator)
            {
                Prefix += ((Operator)n).Op;
                Prefix += " ";
                GetPrefix(((Operator)n).Left);
                GetPrefix(((Operator)n).Right);
            }
            if(n is Operand)
            {
                Prefix += ((Operand)n).Number.ToString();
                Prefix += " ";
            }
        }

        public void GetPostfix(Node n)
        {
            if (n == null) {
                return;
            }
            if (n is Operator)
            {
                GetPostfix(((Operator)n).Left);
                GetPostfix(((Operator)n).Right);
                Postfix += ((Operator)n).Op;
            }
            if (n is Operand)
                Postfix += ((Operand)n).Number.ToString();
            
            Postfix += " ";
        }
        public Node IsInNode(int x, int y)
        {
            Node tmp = null;
            nodes.ForEach(n => { if (n.InNode(x, y)) { tmp = n; } });
            return tmp;
        }
    }
}
