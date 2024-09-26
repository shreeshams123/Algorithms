using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace SortingTechniques
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 80, 30, 90, 40, 50, 70 };
            QuickSorting(a, 0, a.Length - 1);
            Console.WriteLine(string.Join(",",a));
        }

        static void QuickSorting(int[] a, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(a, low, high);
                QuickSorting(a, low, pi-1);
                QuickSorting(a, pi + 1, high);
            }
        }

       static int Partition(int[] a, int low, int high)
        {
            int pivot = a[high];
            int i = low - 1;
            for(int j = low; j < high; j++)
            {
                if (a[j] <= pivot)
                {
                    i++;
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }

            }
            int temp2 = a[i + 1];
            a[i + 1] = pivot;
            a[high] = temp2;
            return i+1;
        }
    }
}
