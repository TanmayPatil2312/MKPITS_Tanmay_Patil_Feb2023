using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace table_mul
{
    internal class Program
    {
        static void Main()
        {
            int num, result=0,i
                ;
            Console.WriteLine(" Enter Number ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Calling table Function");
            result = table(num);
            Console.WriteLine( "{0} * {1} = {2}" + num,i,result);
            Console.WriteLine("\n");

            Console.ReadLine();
        }
        static int table(int n1)
        {
            int i = 1;
            int result = 0; 
            while (i <= 10)
            {
                result = n1 * i;
                i++;
            }
            return n1;
            

        }
    }
}

