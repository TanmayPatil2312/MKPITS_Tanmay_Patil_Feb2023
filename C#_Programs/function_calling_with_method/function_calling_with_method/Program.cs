using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_calling_with_method
{

    internal class Program
    {
        static void Main(string[] args)
        {
            calculate();
        }
        static void calculate()
        {
            int num1, num2, result;
            Console.WriteLine(" Enter Number First : - ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter Number Second : - ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("  Calling Addition Method ");
            result = addition(num1, num2);
            Console.WriteLine(" addition :  " + result);

            Console.WriteLine(" Calling Substraction Method ");
            result = substraction(num1, num2);
            Console.WriteLine(" substraction :  " + result);

            Console.ReadLine();

        }
        static int addition(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }
        static int substraction(int n1, int n2)
        {
            int result = n1 - n2;
            return result;
        }
    }
}
