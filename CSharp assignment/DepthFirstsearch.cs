using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.DepthFirstSearch
{
    class DepthFirstsearch
    {
        public Node root =null;
        public void inOrder(Node root)
        {
            if(root==null)
            {
                return;
            }
            else
            {
                inOrder(root.left);
                Console.WriteLine(root.data);
                inOrder(root.right);
            }
        }
        public void preOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                Console.WriteLine(root.data);
                preOrder(root.left);
                preOrder(root.right);
            }
        }
        public void postOrder(Node root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                postOrder(root.left);
                postOrder(root.right);
                Console.WriteLine(root.data);
            }
        }

        static void Main(string[] args)
        {
            DepthFirstsearch ob = new DepthFirstsearch();
            try
            {
                ob.root = new Node(1);
                ob.root.left = new Node(2);
                ob.root.right = new Node(3);
                ob.root.left.left = new Node(4);
                ob.root.left.right = new Node(5);
                ob.root.right.left = new Node(6);
                Console.WriteLine("DFS InOrder traversal of binary tree is: ");
                ob.inOrder(ob.root);
                Console.WriteLine("DFS preorder traversal of binary tree is: ");
                ob.preOrder(ob.root);
                Console.WriteLine("DFS postOrder traversal of binary tree is: ");
                ob.postOrder(ob.root);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
    class Node
    {

        public int data;
        public Node left, right;
        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }




    
}
