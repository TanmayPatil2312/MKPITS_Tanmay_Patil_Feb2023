using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_field
{
    class Account
    {
        public int actno;
        public string name;
        public static float roi = 4.5f;
        public Account(int actno, string name)
        {
            this.actno = actno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Act No:- " + actno);
            Console.WriteLine("Name :- " + name);
            Console.WriteLine("Rate of Interest :- " + roi);
            Console.ReadLine();
        }
    }
    internal class program
    {

        static void Main(string[] args)
        {
            Account a1 = new Account(156, " Rani ");
            Account a2 = new Account(23, "Tanmay");
            a1.display();
            a2.display();
        }
    }
}

