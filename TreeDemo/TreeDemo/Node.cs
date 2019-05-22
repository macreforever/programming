using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDemo
{
    public class Node
    {
        // A node in a Tree have a key and a node left and a node right
        public int key;
        public Node left, right;
       
        //Node constructor
        public Node(int val)
        {
            key = val;
            left = right = null;
        }
    }

}
