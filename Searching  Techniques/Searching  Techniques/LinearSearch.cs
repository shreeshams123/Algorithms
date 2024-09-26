using System;

namespace Searching__Techniques
{
    internal class LinearSearch
    {
        static void Main(string[] args)
        {
            int[] a = { 20, 30, 40, 50, 60 };
            Console.WriteLine(search(a, 2-0));
        }

       static int search(int[] a,int x)
        {
           for(int i = 0; i < a.Length; i++)
            {
                if ((a[i]==x))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
