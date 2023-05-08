using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQpractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahila", "rose", "lotus", "lily", "hibiscus", "daffodil" };

            var fQuery =
                from flower in flowers
                where (flower.StartsWith("d"))          
                select flower;
            foreach(string f in fQuery)
            {
                Console.WriteLine(f);
            }
            var lQuery = from flower in flowers
                         let len = flower.Length
                         where (len > 3 && len > 5)
                         select flower;
            foreach(var f in lQuery)
            {
                Console.WriteLine(f);
            }
        }
    }
}
