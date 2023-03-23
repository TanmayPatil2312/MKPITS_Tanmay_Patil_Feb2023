using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class vote
    {
        static void Main()
        {
            //program to accept a age from the user and print whether eligible to vote or not
            int age;
            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Not Elegible to Vote");
            }
            else
            {
                Console.WriteLine("Eligible to Vote");
            }
            Console.ReadKey();
        }
    }
}