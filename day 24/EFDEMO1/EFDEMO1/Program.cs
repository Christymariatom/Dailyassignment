using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace EFDEMO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //insert data
           /* using (var context = new empdEntities())
            {
                var std = new NEWCustomer()
                {
                    CustomerID = 6,
                    CustomerName = "Adhi",
                    LastName = "KS",
                    Country = "CHINA",
                    Age = 23,
                    Phone = 918858671                 
                };
                context.NEWCustomers.Add(std);

                context.SaveChanges();
            }

            //updating data
            using (var context = new empdEntities())
{
    var std = context.NEWCustomers.First<NEWCustomer>(); 
    std.CustomerName = "Steve";
    context.SaveChanges();
}*/

            
        }
    }
}
