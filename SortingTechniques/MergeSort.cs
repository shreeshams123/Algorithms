using System;
using System.Collections.Generic;
using System.Text;

namespace SortingTechniques
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            int[] a = { 38, 27, 43, 3, 9, 82, 10 };
            MergeSorting(a, 0, a.Length - 1);
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
        static void MergeSorting(int[]a,int left,int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                MergeSorting(a, left, middle);
                MergeSorting(a, middle + 1, right);
               Merge(a, left, middle, right);
            }
        }

         static void Merge(int[] a, int left, int middle, int right)
        {
            int n1 = middle - left + 1 ;
            int n2 = right - middle;
            int[] newleft = new int[n1];
            int[] newright = new int[n2];
           
            for(int i = 0; i < n1; i++)
            {
                newleft[i] = a[left+i];
            }
            for(int j=0;j<n2;j++)
            {
                newright[j] = a[middle+1+j];
            }
            int d = left; 
            int f=0, k = 0;
            while(f<newleft.Length && k<newright.Length)
            {
                if (newleft[f] < newright[k])
                {
                    a[d++] = newleft[f++];
                }
                else
                {
                    a[d++]= newright[k++];
                }

            }
            while (f < newleft.Length)
            {
                a[d++]=newleft[f++];
            }
            while(k < newright.Length)
            {
                a[d++]=newright[k++];
            }
        }
    }
}
