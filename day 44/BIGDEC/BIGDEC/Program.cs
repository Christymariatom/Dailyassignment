using System;

using System.Collections.Generic;

using System.Linq;

using System.Runtime.InteropServices;

using System.Text;

using System.Threading.Tasks;

namespace bigdecimal

{

    internal class Program

    {

        static void Main(string[] args)

        {

            {

                decimal[] arr = new decimal[5];
                Console.WriteLine("enter the array");
                for (int i = 0; i < arr.Length; i++)

                {
                    arr[i] = decimal.Parse(Console.ReadLine());
                }
                Array.Reverse(arr);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }

            }
        }
    }
}
   



