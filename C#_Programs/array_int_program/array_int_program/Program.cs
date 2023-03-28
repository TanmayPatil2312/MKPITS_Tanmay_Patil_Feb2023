using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_int_program
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 123;
            arr[1] = 223;
            arr[2] = 332;
            foreach (int val in arr)
            {
                Console.WriteLine(" num = " + val);
                Console.ReadKey();
            }
        }
    }
}
