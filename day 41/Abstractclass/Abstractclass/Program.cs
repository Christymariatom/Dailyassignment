using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclass
{



    abstract class Book

    {
       string title;
        public abstract void setTitle(string s);
        public string getTitle()

        {

            return title;

        }

    }
    class MyBook : Book
    {
       public override void setTitle(string s)
        {

            Console.WriteLine("the title is :{0}", s);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the book name : ");
            string str = Console.ReadLine();
            MyBook temp = new MyBook();
            temp.setTitle(str);
        }
    }
}

