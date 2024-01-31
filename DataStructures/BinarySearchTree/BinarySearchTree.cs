using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchTree
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int value)
        {
            data = value;
            left = right = null;
        }
    }

    public class BinarySearchTree
    {
        Node root;

        BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            root = InsertRecord(root, value);
        }

        public Node InsertRecord(Node root, int value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }

            if (value < root.data)
            {
                root.left = InsertRecord(root.left, value);
            }
            else if (value > root.data)
            {
                root.right = InsertRecord(root.right, value);
            }

            return root;
        }

        public void Display(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                Display(root.left);
                Display(root.right);
            }
        }

        public static void Main(string[] ar)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(5);
            binarySearchTree.Insert(4);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(7);

            binarySearchTree.Display(binarySearchTree.root);
            Console.ReadKey();
        }
    }
}
