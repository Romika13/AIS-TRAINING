using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.fibb
{
    class Program
    {
        public static int prime(int num)            //prime function declaration
        {
            int counter=0,i;                       
            for(i=2;i<=num/2;i++)
            {
                if(num%i==0)
                {
                    counter = 1;
                    break;
                }
            }
            if(counter==0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static void fibb(int length)         //fibbonacci function declaration
        {
            int num1 = 0, num2 = 1, sum = 0,l=length,x;
            if(l<=0)                                //invalid length condition
            {
                Console.Write("invalid length");
            }
            else if(l==1)
            {
                Console.Write(num1+" ");
            }
            else if(l==2)
            {
                Console.Write(num1+" ");
                Console.Write(num2+" ");
            }
            else
            {
                Console.Write(num1+" ");
                Console.Write(num2+" ");
                for(x=2;x<l;x++)
                {
                    sum = num1 + num2;
                    num1 = num2;
                    num2 = sum;
                    if(sum==1)
                    {
                        Console.Write(sum+" ");
                        
                    }
                    else
                    {
                        int result = prime(sum);                //prime function call
                        if(result==1)
                        {
                            Console.Write("prime ");
                            
                        }
                        else
                        {
                            Console.Write(sum + " ");
                        }
                    }
                }
                Console.ReadKey();

            }
        }
        static void Main(string[] args)
        {
            try                                                         //for non-numeric value
            {
                Console.Write("enter the length:");                     //user input
                int len = Convert.ToInt32(Console.ReadLine());          //string to int
                fibb(len);                                              //fibb function call
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("exception: "+e.Message);
                Console.ReadKey();
            }
            

        }
    }
}
