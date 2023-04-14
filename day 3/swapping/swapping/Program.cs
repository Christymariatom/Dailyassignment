using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("Enter the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("AFTER SWAPPING");
            Console.WriteLine("FIRST NUMBER ={0}", num1);
            Console.WriteLine("SECOND NUMBER = {0}", num2);

        }
    }
}
