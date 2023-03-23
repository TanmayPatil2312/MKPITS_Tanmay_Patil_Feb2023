using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_square
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(" Calling The Method ");
            int result = calculate_square();
            Console.WriteLine(" Square =  " + result);
            Console.ReadLine();
        }
        static int calculate_square()
        {
            int num;
            Console.WriteLine("Enter Number");
            num=Convert.ToInt32(Console.ReadLine());
            int square = num * num;
            return square;
        }
    }
}
