using System;
using System.Collections.Generic;
using System.Text;

namespace SortingTechniques
{
    internal class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] a = { 50, 20, 10, 40, 30 };
            int temp; 
            for (int j = 0; j < a.Length; j++) 
            {
                int minindex = j;
                for (int i = j+1; i < a.Length; i++)
                {
                    if (a[i] < a[minindex])
                    {
                        minindex = i;
                    }
                }
                temp = a[j];
                a[j] = a[minindex] ;
                a[minindex] = temp ;

            }

           
            foreach (int k in a)
            {
                Console.WriteLine(k);
            }

        }
    }
}
