using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s1 = new shape();
            s1.drawshape();
            Circle c1 = new Circle();
            c1.drawshape();
            Rectangle r1 = new Rectangle();
            r1.drawshape();

                                           //upcasting
            shape s2 = new Circle();
            s2.drawshape();
            shape s3 = new Rectangle();
            s3.drawshape();
           // shape s4 = new Circle();
           // s4.drawshape();
            // ARRAY OF REFERNCE OF BASE REFERENCING
            // DERIVED CLASS OBJECT(UPCASTING)
        }
    }
}
