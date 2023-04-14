using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        public static void Main()
        {
            bool IsEqual = Clscalculator.AreEqual(20, 20);
            if (IsEqual)
            {
                Console.WriteLine("Both are equal");
            }
            else
            {
                Console.WriteLine("Both are not equal");
            }
        }
    }
}
