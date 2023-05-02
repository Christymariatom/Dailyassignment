using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {



            SortedList s = new SortedList();
            s.Add("Maharastra ", "Mumbai");
            s.Add("Karnataka ", "Bangalore");
            s.Add("Andhra Pradesh", "Hyderabad");
            s.Add("Tamilnadu ", "chennai");
            s.Add("Bihar ", "Patna");
            s.Add("Rajastan ", "Jaipur");
            s.Add("Orissa ", "Bhubaneshwar");
            Console.WriteLine("Elements in the SotredList: ");
            foreach (SortedList item in s)
            {
                Console.WriteLine(item.Keys.ToString());
            }
        }
    }
}


  
