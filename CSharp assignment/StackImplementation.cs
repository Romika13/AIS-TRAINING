using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.stack
{
    

    class Program
    {
        static int MAX = 100;           //static and global variable as remains constant throughout
        int top =-1;
        int[] st = new int[MAX];
         
        public void push(int num)       //function declaration and definition for push
        {
        if (top >= MAX)                 //checking condition for overflow
        {
            Console.WriteLine("stack overflow");
        }
        else
        {
            st[++top] = num;
        }
        //Console.ReadKey();
    }
    public void pop()           //function declaration and definition for pop
        {
        if (top < 0)            //checking condition for underflow
        {
            Console.WriteLine("empty is empty");
        }
        else
        {
            Console.WriteLine("poped element is:{0}", st[top--]);
        }
        //Console.ReadKey();
    }
    public void display()           //function declaration and definition for display
        {
        int i;
        if (top < 0)
        {
            Console.WriteLine("empty is empty");
        }
        for (i = 0; i <= top; i++)
        {
            Console.WriteLine(st[i] + "\n");
        }
    }

    static void Main(string[] args)
        {
            Program ob = new Program();         //object creation
            
            while(true)
            {
                Console.WriteLine("enter the valid choice from following: \n1.push\n2.pop\n3.dispaly\n4.exit");
                int choice = Convert.ToInt32(Console.ReadLine());       //input of choice from user
                switch (choice)                                        //condition on the basis of choice entered
                {
                    case 1:
                        //Console.WriteLine("Case 1");
                        Console.WriteLine("enter the number to push");      //user input to be pushed
                        try                                                 //exception handling
                        {
                            int num = Convert.ToInt32(Console.ReadLine());
                            ob.push(num);                                   //function call
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);                  //message with exception type
                        }
                        
                        
                        break;
                    case 2:
                        ob.pop();                                       //function call
                        break;
                    case 3:
                        ob.display();                                   //function call
                        break;
                    case 4:
                         Environment.Exit(1);                           //to exit from system
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
