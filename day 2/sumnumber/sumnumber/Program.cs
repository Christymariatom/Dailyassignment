using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            y = int.Parse(Console.ReadLine()); 
            int result = sumofnumber(x,y);
            Console.WriteLine("The result is {0} ", result);


        }
        static int sumofnumber(int x, int y)
        {
            if  (x == y)
            {
               int  ans = (x + y) * 3;
                return ans;
            }
            else
            { 
              int  ans1 = (x + y);
                return ans1;
            }
        }
    }
}
