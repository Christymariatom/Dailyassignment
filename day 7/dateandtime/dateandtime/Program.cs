using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateandtime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            Console.WriteLine(dt);
            DateTime dt2 = new DateTime(2015, 12, 31);
            Console.WriteLine(dt2);
            DateTime dt3 = new DateTime(2015, 12, 31,5,30,40);
            Console.WriteLine(dt3);
            DateTime dt4 = new DateTime(2015, 12, 31,5,30,45,DateTimeKind.Utc);
            Console.WriteLine(dt4);
            /* throw expection
             * DateTime dt5 = new DateTime(2045,13,50);
             * Console.WriteLine(dt5);*/

           
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);
            DateTime todaysDate = DateTime.Today; 
            Console.WriteLine(todaysDate);
            DateTime todaysDay = DateTime.Today;    
            Console.WriteLine(todaysDay);
            //DateTimeUTC = DateTime.UtcNow;// returns current UTC date and time

            DateTime maxDateTimeValue = DateTime.MaxValue; 
            Console.WriteLine(maxDateTimeValue);
            DateTime minDateTimeValue = DateTime.MinValue;
            Console.WriteLine(minDateTimeValue);

            DateTime dt6 = new DateTime(345768000000000);
            Console.WriteLine(dt6);
            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);

            DateTime dt7 = new DateTime(2006, 5, 21);
            TimeSpan ts = new TimeSpan(6 , 16, 17);
            DateTime newdate = dt7.Add(ts);
            Console.WriteLine(newdate); 
                


        }
    }
}
