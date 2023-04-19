using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding
{
    class Account
    {
        public int bal = 1000;
        public void deposit(int amount)
        {
            Console.WriteLine("deposit method of account class");
            Console.ReadLine();
        }
    }
    class Saving : Account
    {
        int interest = 500;
        public void deposit(int amount)
        {
            bal = bal + amount + interest;
            Console.WriteLine("deposit bal in " + bal);
            Console.ReadLine();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Saving s = new Saving();
            s.deposit(200);
        }
    }
}
