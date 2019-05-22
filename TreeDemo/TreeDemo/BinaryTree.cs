using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDemo
{
    public class BinaryTree
    {   
        public Node root;

        //BinaryTree Constructor
        public BinaryTree()
        {
            root = null;
        }

        //Print in Inorder Recursively
        public void printInorder(Node node)
        {
            if (node == null) return;
            printInorder(node.left);
            Console.Write(node.key+ " ");
            printInorder(node.right);
        }

        //Print in Preorder Recursively
        public void printPreorder(Node node)
        {
            if (node == null) return;
            Console.Write(node.key + " ");
            printPreorder(node.left);
            printPreorder(node.right);


        }

        //Print in Postorder Recursively
        public void printPostorder(Node node)
        {
            if (node == null) return;
            printPostorder(node.left);
            printPostorder(node.right);
            Console.Write(node.key + " ");

        }

       

    }
}
