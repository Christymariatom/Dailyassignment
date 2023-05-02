using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    internal class Program
    {
        static void Add (int i,int j)
        {
            Console.WriteLine ("SUM"+(i+j));
        }
        static void sub(int i, int j)
        {
            Console.WriteLine("SUB" + (i - j));
        }
        public delegate void reftomethod(int i ,int j);
        static void Main (string[]args)
        {
            /* Add(20, 20);
             reftomethod r1 = Add;
                 r1(20,20);
             reftomethod r2 = sub;
                 r2(10, 20);*/
            reftomethod multicast = Add;
            multicast += sub;
            multicast(10, 90);
            Console.WriteLine("After removing sub");
            multicast -= sub;
            multicast(10, 90);
        }
            
        }
    }


