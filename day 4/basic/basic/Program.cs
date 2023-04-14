using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            string str = "India is great";
                for (i = 0; i < str.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(str[i]);
                        }
            }            

        }
    }
}
