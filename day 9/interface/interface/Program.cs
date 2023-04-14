using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 class Program
{
    public static void Main(string[] args)
    {
        IFigure fig = null;
        Console.WriteLine("Enter 'C' for Circle or 'S' for Square");
        string ch = Console.ReadLine();
        if (ch == "S")
            fig = new Square();
        else if (ch == "C")
            fig = new circle();
        fig.Dimension = 10;
        Console.WriteLine(fig.Area());
        Console.WriteLine(fig.Perimeter());


    }
}