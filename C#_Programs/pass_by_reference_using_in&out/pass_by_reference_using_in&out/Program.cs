using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_reference_using_in_out
{
    internal class Program
    {
         static void Main()
        {
           
            Console.WriteLine("  Enter Radius ");
            int radius=Convert.ToInt32(Console.ReadLine());
            float area = 0.0f;
            float cir = 0.0f;
            calculate_area(radius , ref area, ref cir);
            Console.WriteLine("area = " + area);
            Console.WriteLine("circumference = " +  cir);
            Console.ReadLine();
        }
        static void calculate_area( int r , ref float a, ref float c )
        {
            
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;
        }
    }
}
