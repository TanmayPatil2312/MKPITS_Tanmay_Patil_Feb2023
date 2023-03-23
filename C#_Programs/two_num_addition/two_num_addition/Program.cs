using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    using System;
    //system is a namespace
    //namespace is a unit to group related classes, packages

    namespace numaddition
    {
        class Program
        {
            static void Main()
            {
                int num1, num2, addition;
                Console.WriteLine("please enter number 1 :- ");
                num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number 2 :- ");
            num2 = Convert.ToInt32(Console.ReadLine());

            addition = num1 + num2;
                Console.WriteLine("addition of a number is " + addition);
                Console.ReadKey();
            }
        }
    }
