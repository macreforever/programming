using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crete an instance of BinryTree
            BinaryTree tree = new BinaryTree();

            
            //Insert nodes in tree
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            //Print tree in Preorder Root, Left, Right
            tree.printPreorder(tree.root);
            Console.WriteLine();
            //Print tree in Inorder Left, Root, Right
            tree.printInorder(tree.root);
            Console.WriteLine();
            //Print tree in Postorder Left, Right, Root
            tree.printPostorder(tree.root);


            Console.ReadLine();
        }
    }
}
