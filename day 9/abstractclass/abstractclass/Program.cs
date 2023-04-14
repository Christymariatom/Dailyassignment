using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass
{
     class Program
    {
        static void Main(string[] args)
        {
            figure fig = new square();
            fig.dimensions = 50;
                Console.WriteLine(fig.Area());
                Console.WriteLine(fig.Perimeter());

        }
        


    }
}
