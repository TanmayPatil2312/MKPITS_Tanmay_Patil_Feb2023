using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    using System;
    //system is a namespace
    //namespace is a unit to group related classes, packages

    namespace threenumadd
    {
        class Program
        {
            static void Main()
            {
                int num1, num2, num3, total;

                Console.WriteLine("please enter number1 :- ");
                num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter number2 :- ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter number3 :- ");
            num3 = Convert.ToInt32(Console.ReadLine());

            total = num1 + num2 + num3;
                Console.WriteLine("Total is :-- " + total);

                Console.ReadKey();
            }
        }
    }

