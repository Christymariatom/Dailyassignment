using System;

namespace sorting1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = {0, 67,43,92,78,34 };
            int temp;
                for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(ar[i] + "\t");
            }
            Console.WriteLine();
            // logic
            for (int j = 0; j < ar.Length; j++)
            {
                for (int i = j; i < ar.Length-1; i++)
                {
                    if (ar[j] > ar[i + 1])
                    {
                        temp = ar[j]; 
                        ar[j] = ar[i + 1];
                        ar[i + 1] = temp;
                    }

                }
            }
            Console.WriteLine("Sorted array :");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(ar[i] + "\t");
            }
            Console.WriteLine();
        }

    }
}
