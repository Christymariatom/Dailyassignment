using System;



namespace Telephone

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicPhone phone = new ElectronicPhone();
            phone.Ring();
        }
        public class Telephone
        {
            protected string _Phonetype;
            public string phonetype
            {
                get { return _Phonetype; }
                set { if (_Phonetype != null) _Phonetype = value; }
            }
            public void Ring()
            {
                Console.WriteLine("Ringing the {0}", _Phonetype);

            }
            public Telephone()
            {

            }
            public Telephone(string phone)
            {
                _Phonetype = phone;
            }
        }
        public class ElectronicPhone : Telephone
        {
            public ElectronicPhone()
            {
                _Phonetype = "Digital";

            }
        }
    }
}