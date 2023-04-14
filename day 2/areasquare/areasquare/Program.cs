using System;


namespace areasquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            double area;
            Console.WriteLine("enter side length");
            s = double.Parse(Console.ReadLine());
            area = calcarea(s);
            Console.WriteLine("The area of the square with side {0} is {1}", s, area);

        }
        static double calcarea(double s)
        {
            double area = 0.0;
            area = s * s;
            return area;

        }
    }
}
