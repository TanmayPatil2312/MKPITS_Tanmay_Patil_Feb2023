using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto_program
{
    internal class Program
    {
        public static void Main()
        {
            int num1, num2, result = 0;
            char op;
            Console.WriteLine(" Enter Number 1 ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number 2 ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Enter Operator + , - , *");
            op = Convert.ToChar(Console.ReadLine());

            if (op == '+')
            {
                goto addition;
            }
            else if(op=='-')
            {
                goto substraction;
            }
            else
            {
                goto end;
            }


            addition:
            result = num1 + num2;
            goto end;


            substraction:
            result = num1 - num2;
            goto end;


            end:
            Console.WriteLine(" Final Result is " + result);
            Console.ReadKey();

        }
    }

}