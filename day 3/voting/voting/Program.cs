using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("ENTER YOUR AGE");
            age = int.Parse(Console.ReadLine());
            int res = voting(age);
            if (res == 1)
            {
                Console.WriteLine("Your are eligible to vote");

            }
            else
            {
                Console.WriteLine("Your are not eleigible to vote");
            }
            Console.ReadKey();
        }
        static int voting(int a)
        {
            if (a >= 18)
            { 
                return 1;
            }
            else
            { 
                return 0;
            }

        }

    }
    
}
