using System;
using System.Collections.Generic;

namespace carpoolreq1

{

    internal class Program1

    {
        static void Main(string[] args)

        {
            List<Member> ls = new List<Member>();
            for (int i = 0; i < 2; i++)

            {

                Console.WriteLine($"member{i + 1}");
                Console.WriteLine("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("first name:");
                string firstname = Console.ReadLine();
                Console.WriteLine("last name:");
                string lastname = Console.ReadLine();
                Console.WriteLine("email:");
                string email = Console.ReadLine();
                Console.WriteLine("contact number:");
                string contactnumber = Console.ReadLine();
                Console.WriteLine("license number:");
                string licensenumber = Console.ReadLine();
                Console.WriteLine("license start date:");
                DateTime licensestart = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("license end date:");
                DateTime licenseend = DateTime.Parse(Console.ReadLine());
                Member member = new Member(id, firstname, lastname, email, contactnumber, licensenumber, licensestart, licenseend);

                ls.Add(member);

            }
            foreach (Member m in ls)
            {
                Console.WriteLine(m.ToString());
                if (ls[0].Equals(ls[1]))
                {
                    Console.WriteLine("member 1 is same as member 2");
                }
                else
                {
                    Console.WriteLine("MEMBER 1 AND MEMBER 2 ARE DIFFERENT");
                }
            }
        }
    }
}

