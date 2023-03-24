
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_operator
{
    class operatorwithuserdefinedno
    {
        static void Main()
        {
           // wap to accept 2 no and operator like + -*and display the result  (dated:- 20/03/2023)
            int s1, s2;
            char op;
            int res = 0;
            Console.WriteLine("enter num1 ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2 ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter operator like + - * ");
            op = Convert.ToChar(Console.ReadLine());
            if (op == '+')
                res = s1 + s2;
            else if (op == '-')
                res = s1 - s2;
            else if (op == '*')
                res = s1 * s2;
            else
                Console.WriteLine("invalid operator");

            Console.WriteLine("result = " + res);
            Console.ReadKey();
        }
    }
}

