using System;
using System.Collections.Generic;
using System.Text;

namespace SortingTechniques
{
   class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] a = { 20, 50, 40, 30, 10 };
            int key=0;
            for (int i = 1; i < a.Length; i++)
            {
                key = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--; 
                }
                a[j+1] = key;
            }
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
