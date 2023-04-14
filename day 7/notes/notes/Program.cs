using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount :");
            int amount = int.Parse(Console.ReadLine());
            int w = amount / 2000;
            amount = amount % 2000;
            Console.WriteLine("No of 2000 notes : " + w);
            int x = amount / 500;
            amount = amount % 500;
            Console.WriteLine("No of 500 notes : " + x);
            int y = amount / 200;
            amount = amount % 200;
            Console.WriteLine("No of 200 notes : " + y);
            int z = amount / 100;
            amount = amount % 100;
            Console.WriteLine("No of 100 notes : " + z);
            int a = amount / 50;
            amount = amount % 50;
            Console.WriteLine("No of 50 note : " + a);
            int b = amount / 10;
            amount = amount % 10;
            Console.WriteLine("No of 10 note : " + b);
            int c = amount / 5;
            amount = amount % 5;
            Console.WriteLine("No of 5 notes : " + c);
            int d = amount / 2;
            amount = amount % 2;
            Console.WriteLine("No of 2 notes : " + d);
            int e = amount / 1;
            amount = amount % 1;
            Console.WriteLine("No of 1 notes : " + e);
            Console.ReadKey();
        }
    }
}

