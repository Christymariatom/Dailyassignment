using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WriteAndReader
{
    static string file = @"D:\UST DEMO\day 13\streamwriter";
    static void Main()
    {
        Write();
        Read();
    }
    static void Write()
    {
        StreamWriter fileStream = new StreamWriter(file);
        fileStream.WriteLine("WHAT IS THIS FILE IF,FULL OF CARE,");
        fileStream.WriteLine(" WE HAVE NO TIME TO STAND AND STARE");
        fileStream.Close();
    }
    static void Read()
    {
        StreamReader fileStream = new StreamReader(file);
        string s = null;
        while ((s = fileStream.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
        fileStream.Close();
    }
}
