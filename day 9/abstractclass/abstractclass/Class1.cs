using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass
{

        abstract class figure
        {
            public int dimensions;
            public abstract double Area();
            public abstract double Perimeter();
        }
        class square : figure
        {
            public override double Area()
            {
                return dimensions * dimensions;
            }
            public override double Perimeter()
            {
                return 4 * dimensions;
            }

        }
        class circle : figure
        {
            public override double Area()
            {
                return Math.PI * dimensions * dimensions;
            }
            public override double Perimeter()
            {
                return 2 * Math.PI * dimensions;
            }
        }
    }
