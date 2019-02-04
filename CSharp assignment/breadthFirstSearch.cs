using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.BreadthFirstSearch
{
    class breadthFirstSearch
    {
        private Node root = null;
        void traverseLevelWise(Node root,int level)
        {
            if(root==null)
            {
                return;
            }
            else
            {
                if (level == 0)
                    Console.WriteLine(root.data);
                else
                {
                    traverseLevelWise(root.lChild, level - 1);
                    traverseLevelWise(root.rChild, level - 1);
                }
            }
        }

        public int height(Node root)
        {
            if(root==null)
            {
                return 0;
            }
            else
            {
                int lheight = height(root.lChild);
                int rheight = height(root.rChild);
                if (lheight > rheight)
                    return (lheight + 1);
                else
                    return (rheight + 1);

            }
        }
        public void display(Node root)
        {
            int h= height(root);
            for(int i =0; i<h;i++)
            {
                traverseLevelWise(root, i);
            }
        }
        static void Main(string[] args)
        {
            breadthFirstSearch ob = new breadthFirstSearch();
            try
            {
                ob.root = new Node(23);
                ob.root.lChild = new Node(28);

                ob.root.rChild = new Node(31);

                ob.root.lChild.lChild = new Node(42);

                ob.root.lChild.rChild = new Node(53);

                ob.root.rChild.lChild = new Node(68);

                Console.WriteLine("BFS traversal of tree is: ");

                ob.display(ob.root);
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
        public Node lChild;
        public Node rChild;
        public Node(int item)
        {
            data = item;
            lChild = rChild = null;
        }
    }
}
