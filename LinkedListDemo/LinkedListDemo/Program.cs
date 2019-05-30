using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{

    public class Node
    {
        public int data;
        public Node next;

        //Constructor of the class Node
        public Node(int i)
        {
            data = i;
            next = null;
        }

        

        public void Print()
        {
            //Print all nodes
            Console.Write("|" + data + "|->");
            if (next != null)
            {
                next.Print();
            }
        }

        public void AddToEnd(int data)
        {
            //Add a node to the end
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }

        public void AddSorted(int data)
        {
            //Add a node in a sorted form
            if (next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
        }
    }
    public class MyList
    {
        public Node headNode;

        //Constructor
        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            //Add a new node at the end of the list
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                headNode.AddToEnd(data);
            }
        }

        public void AddToBeginning(int data)
        {
            // Add a new node in the beggining of the list
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }

        public void AddSorted(int data)
        {
            //Add a new node in a sorted way

            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                AddToBeginning(data);
            }
            else
            {
                headNode.AddSorted(data);
            }
        }

        public void DeleteSortedNode(int data)
        {
            //This method delete a node
            if(headNode == null) return;

            //If the first node is deleted now the headNode is the second node pointed in headNode.next
            if (headNode.data == data)
            {
                headNode = headNode.next;
            }
            else {
                Node previus = headNode;
                Node current = headNode.next;

                while (current != null)
                {
                    if (current.data == data)
                    {
                        previus.next = current.next;
                        break;
                    }

                    previus = current;
                    current = current.next;
                }
            }
           
            

        }

        public void PrintH()
        {
            //Print all nodes 
            if (headNode != null)
            {
                headNode.Print();
            }
        }

        public void insertAfter(int prev_node, int new_data)
        {
            //This method insert a new node in a specific position
            if (headNode == null) return; //if head is null return.
            Node current = headNode;

            Node new_node = new Node(new_data);

            //This is in case of insert a node in the last node
            if (current.next == null)
            {
                headNode.AddToEnd(new_data);
                return;
            }

            
            while (current.next != null)
            {
                //find the previous node to insert a new node.
                if (prev_node == current.data)
                {
                    new_node.next = current.next;
                    current.next = new_node;
                }
                current = current.next;
            }

            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of my linked list called MyList
            MyList list = new MyList();
            list.AddSorted(9);
            list.AddSorted(5);
            list.AddSorted(7);
            list.AddSorted(11);
            list.PrintH();
            Console.WriteLine();
            //Insert an element in a specific position
            list.insertAfter(5, 6);
            list.PrintH();
            Console.WriteLine();
            //Delete a Node
            list.DeleteSortedNode(5);
            list.PrintH();

            Console.ReadLine();

        }
    }
}
