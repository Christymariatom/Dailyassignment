using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class shape

    {
        public virtual void drawshape()
        {
            Console.WriteLine("DRAWING SHAPE");
        }
     }
    class Circle : shape
    {
        public override void drawshape()

        {
            Console.WriteLine("DRAWING CIRCLE");
        }
    }
    class Rectangle : shape
    {
        public override void drawshape()

        {
            Console.WriteLine("DRAWING RECTANGLE");
        }
    }
}
