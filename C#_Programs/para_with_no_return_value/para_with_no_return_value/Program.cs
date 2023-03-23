using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para_with_no_return_value
{
    internal class Program
    {
        static void Main()
        {
            calculate();
        }
        static void calculate()
        {
            int num1, num2;
            Console.WriteLine(" Enter Number First : - ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter Number Second : - ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("  Calling Addition Method ");
             addition(num1, num2);

            Console.WriteLine(" Calling Substraction Method ");
            substraction(num1, num2);

            Console.ReadLine();

        }
        static void addition(int n1, int n2)
        {
            int result = n1 + n2;
            Console.WriteLine(" Addition :  " + result);
        }
        static void substraction(int n1, int n2)
        {
            int result = n1 - n2;
            Console.WriteLine(" Substraction :  " + result);

        }
    }
}
