using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace with_para_with_value
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(" Enter Number ");
            int n1=Convert.ToInt32(Console.ReadLine());
            int result = calculate_square(n1);
            Console.WriteLine(" Square =  " + result);
            Console.ReadKey();
            Console.ReadLine();
        }
        static int calculate_square(int num)
        {
            int square = num  * num;
            return square;
        }
    }
}
