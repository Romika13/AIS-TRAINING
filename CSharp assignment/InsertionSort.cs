using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.Insertionsort
{

    class Program
    {
        public static void insertionSort(int[] a,int l)
        {
            //int[] arr1 = new int[l];
            int value, i, j,counter;
            for(i=1;i<l;i++)
            {
                value = a[i];
                counter = 0;
                for(j=i-1;j >= 0 && counter!=1 ;)
                {
                    if (value < a[j])
                    {
                        a[j + 1] = a[j];
                        j--;
                        a[j + 1] = value;
                    }
                    else counter = 1;

                }
            }
            for(i=0;i<l;i++)
            {
                Console.WriteLine("{0}th element is:{1}", i, a[i]);
                
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the length of elements:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            int[] arr = new int[length];
            Console.WriteLine("Enter the elements:");
            for(i=0;i<length;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            insertionSort(arr, length);

        }
    }
}
