using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_parameter_program
{
    internal class Program
    {
     static void Main()
        {
            int radius;
            float cir, area;
            Console.WriteLine("ENter Radius ");
            radius=Convert.ToInt32(Console.ReadLine());
            calculate_area(radius, out area, out cir);
            Console.WriteLine("area =  " + area);
            Console.WriteLine("circumference = " + cir);
            Console.ReadKey();
        }
        static void calculate_area( int r , out float a ,out float c)
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;
        }
    }
}
