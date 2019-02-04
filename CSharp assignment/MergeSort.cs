using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R.merge
{
    class Program
    {
        public int[] merge(int[] array,int left,int Mid,int right)
        {
            int i, j, k;
            int n1 = Mid - left + 1;
            int[] lArr = new int[n1];
            int n2 = right - Mid;
            int[] rArr = new int[n2];
            for(i = 0;i<n1;i++)
            {
                lArr[i] = array[left+i];
            }
            for (i = 0; i < n2; i++)
            {
                rArr[i] = array[1+ i+Mid];
            }
            i = 0;
            j = 0;
            k = left;
            while(i<n1&&j<n2)
            {
                if(lArr[i]<rArr[j])
                {
                    array[k] = lArr[i];
                    i++;
                }
                else
                {
                    array[k] = rArr[j];
                    j++;
                }
                k++;
            }
            while(i<n1)
            {
                array[k] = lArr[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                array[k] = rArr[j];
                j++;
                k++;
            }

            return array;

        }
        public int[] mergeSort(int[] array,int left,int right)
        {
            int[] array1 = new int[left + right];
            if (left<right)
            {
                int mid = (left + right) / 2;
                mergeSort(array, left, mid);
                mergeSort(array, mid + 1, right);
                
               array1 = merge(array, left, mid, right);

            }
            return array1;

        }
        static void Main(string[] args)
        {
            Program ob = new Program();
            Console.WriteLine("enter the length of array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            for(int i =0;i<length;i++)
            {
                Console.WriteLine("enter the {0}th element", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("before mergesort:\n");
            for (int i = 0; i < length; i++)
            {

                Console.WriteLine(array[i] + " ");

            }
            //int[] newArray = new int[length];
            ob.mergeSort(array, 0,length-1);
            Console.WriteLine("after mergesort:\n");
            for (int i = 0; i < (length); i++)
            {

                Console.WriteLine(array[i] + " ");

            }

            Console.ReadKey();
        }
        
    }
}
