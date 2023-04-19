using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accountinfo_with_form
{
    class Account
    {
        public int bal = 1000;
        public virtual void deposit(int amt)
        {
            Console.WriteLine("deposit method of account class");
        }
    }
    class Saving : Account
    {
        int interest = 500;
        public override void deposit(int amt)
        {
            bal = bal + amt + interest;
            Console.WriteLine("deposit bal " + bal);
        }
    }
    class Current : Account
    {
        public override void deposit(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("desposited without interest bal is " + bal);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("Enter Amount ");
            amount= Convert.ToInt32(Console.ReadLine());
            Account Act = null;
            string Acttype;
            Console.WriteLine("Enter account type saving or current ");
            Acttype= Console.ReadLine();
            if(Acttype=="Saving")
            {
                Act = new Saving();
            }
            else if (Acttype=="Current")
            {
                Act=new Current();
            }
            Act.deposit(amount);
        }
    }
}
