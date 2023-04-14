using System;

namespace calcarea
{
     class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            double area;
            Console.WriteLine("enter  radius :");
            r = int.Parse(Console.ReadLine());
            area = calcarea(r);
            Console.WriteLine("area of circle with radius {0} is {1}", r, area);
        }
        static double calcarea(double r)
        {
            double area = 0.0;
            area=3.14 * r * r;
            return area;
        }
        
        
    }
}
