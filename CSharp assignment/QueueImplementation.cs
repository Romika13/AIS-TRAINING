using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.queue
{
    class Program
    {
        static int MAX = 100;
        int front = 0, rear = -1;
        int[] queue = new int[MAX];
        public void insert(int num)
        {
            if (rear == MAX - 1)
            {
                Console.WriteLine("overflow");
            }
            else
            {
                queue[++rear] = num;
            }
        }
        public void delete()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("overflow");
            }
            else
            {
                Console.WriteLine("deleted item is {0}", queue[front]);
                front++;
            }

        }
        public void display()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");

            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + queue[i]);
                }
            }

        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            while (true)
            {
                Console.WriteLine("enter the valid choice from following: \n1.insert\n2.delete\n3.dispaly\n4.exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Console.WriteLine("Case 1");
                        Console.WriteLine("enter the number to insert");
                        int num = Convert.ToInt32(Console.ReadLine());
                        ob.insert(num);
                        break;
                    case 2:
                        ob.delete();
                        break;
                    case 3:
                        ob.display();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
                Console.ReadKey();

            }
        }

    }
}
