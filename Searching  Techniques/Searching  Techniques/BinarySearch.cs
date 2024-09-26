using System;
using System.Collections.Generic;
using System.Text;

namespace Searching__Techniques
{
   class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30, 40, 50 };
            Console.WriteLine(Search(a,0,a.Length-1,25));
        }

        static int Search(int[] a,int low,int high,int x)
        {

            while (low <=high)
            {
                int middle = low + (high - low) / 2;
                if (a[middle] == x)
                {
                    return middle;
                }
                else if (a[middle] > x)
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }
            return -1;
        }
    }
}
