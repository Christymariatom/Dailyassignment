﻿using System;
namespace menu

{
    public class Account
    {
        
        public int Id;
        public string Name;
        public decimal Balance;
        public Account()
        {
            Console.WriteLine("Object Created");
        }
        public void CreateAccount(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("***** Account Information *****");
            Console.WriteLine("Account Id:" + Id);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Opening Balance:" + Balance);
        }
        public void Deposit(decimal amount)
        {
           // Console.WriteLine("AMOUNT TO DEPOSIT: ")
            //    decimal amount = decimal.Parse(Console.ReadLine());
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (Balance - amount < 500)
                Console.WriteLine("Insufficient Balance");
            else
                this.Balance -= amount;
           
        }
    }
}
    