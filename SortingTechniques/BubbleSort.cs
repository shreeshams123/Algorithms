using System;

namespace SortingTechniques
{
   class BubbleSort

    {
        static void Main(string[] args)
        {
            int[] a = { 20, 10, 50, 40, 30 };
            int temp;
            for(int i = 0; i < a.Length - 1; i++)
            {
                for(int j = 0; j < a.Length - 1-i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j]= a[j + 1];
                        a[j+1]= temp;
                    }
                }
            }
            foreach(var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
