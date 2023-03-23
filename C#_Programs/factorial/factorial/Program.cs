using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_number
{
    internal class Program
    {
        static void Main()
        {
            int num, result;
            Console.WriteLine(" Enter Number ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Calling Factorial Function");
            result = factorial(num);
            Console.WriteLine(" factorial = " + result);
            Console.ReadLine();
        }
        static int factorial(int num)
        {
            int fact = 1;
            do
            {
                fact = fact * num;
                num = num - 1;
            } while (num > 0);
            return fact;
           
        }
    }
}

