using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twonumgreater
{
    internal class program
    {
        static void Main(string[] args)
        {
            // WAP  to accept 2 no and print grater no.
            int num1, num2;
            Console.WriteLine("Enter First Number :- ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number :- ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if(num1>num2)
            {
                Console.WriteLine("  Num 1 is Greater :-  " + num1 +  "\n");
            }
            else
            {
                Console.WriteLine(" Num 2 is Greater:-  " + num2 +  "\n");
            }
            Console.ReadLine();
        }
    }
}
