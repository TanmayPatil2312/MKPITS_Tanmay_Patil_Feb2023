using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var_len_params_prog
{
    internal class Program
    {
        static void Main()
        {
            int total;
            total = calculate ( 3, 5, 6, 7, 8, 9);
            Console.WriteLine("total =  " +total );
            Console.ReadKey();
        }
        static int calculate(params int [] val)
        {
            int  total = 0;
            for (int counter = 0; counter < val.Length; counter++)
            {
                total = total + val[counter];
            }
            return total;
        }
    }
}
