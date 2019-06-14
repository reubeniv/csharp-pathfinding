using System;
using System.Collections.Generic;
using System.Text;

namespace Pathfinder
{
    public class Node
    {
        string data;
        Node parent;
        int depth;

        public Node(string data, Node left, Node right, Node parent)
        {
            this.data = data;
            this.parent = parent;
        }

        public Node(string data, Node parent)
        {
            this.data = data;
            this.parent = parent;
        }

        public string getData()
        {
            return this.data;
        }

    }
}
