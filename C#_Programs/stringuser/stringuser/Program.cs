using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringuser
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program to accept name from the user and print it
            string name;

            Console.WriteLine("enter your good name ");

            name = Console.ReadLine();

            Console.WriteLine("name entered = " + name);

            Console.ReadLine();

            Console.ReadKey();

        }
    }

}
