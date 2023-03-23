using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    using System;
    //system is a namespace
    //namespace is a unit to group related classes, packages

     namespace area_rect

    {
        class Program
        {
            static void Main()
            {
                int area, length, breadth;
                Console.WriteLine("please enter length:-");
                length = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("please enter breadth:-");
                breadth = Convert.ToInt32(Console.ReadLine());
                area = length * breadth;
                Console.WriteLine("area of a rectangle is " + area);
                Console.ReadKey();
            }
        }
    }

