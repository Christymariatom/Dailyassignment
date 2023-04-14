//Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplecalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, ch;
            Console.WriteLine("****************************************");
            Console.WriteLine("***********SIMPLE CALCULATOR************");
            Console.WriteLine("****************************************");
            Console.WriteLine("ENTER FIRST NUMBER");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER SECOND NUMBER");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Options are:");
            Console.WriteLine("1 . Addition");
            Console.WriteLine("2 . Substraction");
            Console.WriteLine("3 . Multiplication");
            Console.WriteLine("4 . Division");
            Console.WriteLine("Enter your choice");
            ch = int.Parse(Console.ReadLine());


            switch(ch)
            {
                case 1:
                    Console.Write("The sum of  {0} and {1} is {2}", num1, num2, num1 + num2);
                    break;
                    case 2:
                    Console.WriteLine("The Substraction of {0}  and {1} is: {2}", num1, num2, num1 - num2);
                    break;
                    case 3:
                    Console.WriteLine("The Multiplication of {0}  and {1} is: {2}",num1,num2,num1*num2);
                    break;
                    case 4:
                    Console.WriteLine("The Divison of {0}  and {1} is: {2}", num1, num2, num1 / num2);
                    break;

                default:
                    Console.Write("Check the choice\n");
                    break;
            }
        }
    }
}
