using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEECOLLECTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Student Type");
            string studentType = Console.ReadLine();
            Console.WriteLine("Enter the tution fee");
            float tutionFee = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the bus fee");
            float busFee = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the hostel fee");
            float hostelFee = float.Parse(Console.ReadLine());
            float TotalFee = CalculateFee(studentType,tutionFee, busFee, hostelFee);
            Console.WriteLine("The fees need to paid is Rs. " +TotalFee);
        }
        static float CalculateFee(string studentType, float tuitionFee, float busFee, float hostelFee)

        {
            float totalFee = 0;
            if (studentType == "MSDS")
            {
                totalFee = tuitionFee + busFee;
            }

            else if (studentType == "MSH")
            {
                totalFee = tuitionFee + hostelFee;
            }

            else if (studentType == "MGSDS")
            {
                totalFee = 1.5f * tuitionFee + busFee;
            }

            else if (studentType == "MGSH")
            {
                totalFee = 1.5f * tuitionFee + hostelFee;
            }

            return totalFee;

        }

    }

}
