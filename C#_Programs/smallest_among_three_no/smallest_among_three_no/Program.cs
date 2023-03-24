using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smallest_among_three_no
{
        internal class program
        {
            static void Main(string[] args)
            {
                // WAP  to accept 3 no and print Smallest no.
                int num1, num2, num3;
                Console.WriteLine("Enter First Number :- ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number :- ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Third Number :- ");
                num3 = Convert.ToInt32(Console.ReadLine());
                if (num1 < num2)
                {
                    if (num1 < num3)
                    {
                        Console.WriteLine("  Num 1 is Smallest among three is :-  " + num1 + "\n");

                    }
                    else
                    {
                        Console.WriteLine(" Num 3 is Smallest among three is :-  " + num3 + "\n");
                    }
                }
                else if (num2 < num3)
                {
                    Console.WriteLine(" Num 2 is Smallest among three is " + num2 + "\n");
                }
                else
                {
                    Console.WriteLine(" Num 3 is Smallest among three is " + num3 + "\n");
                }

                Console.ReadLine();
            }

        }

    

}
