using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum2
{
    class perimeter
    {
        public enum shapes
        {
            circle, square, rectangle ,parallelogram , cone 
        }
        public void peri (int val , shapes s1)
        {
            if(s1==0)
            {
                Console.WriteLine("circumference of the circle" + 2 * 3.14 * val);
            }
            else
            {
                Console.WriteLine("perimeter of the square is " + 4 * val);
            }
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            perimeter a1 = new perimeter();
            a1.peri(3, perimeter.shapes.circle);
            a1.peri(4, perimeter.shapes.square);
            Console.ReadLine();

        }
    }
}
