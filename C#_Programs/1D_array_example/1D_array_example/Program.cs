using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_array_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for (int i=0; i<10; i++)
            {
                Console.WriteLine("Enter Number");
                num[i]=Convert.ToInt32(Console.ReadLine());
            }
            //display the value of array
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("num [ {0} ] = {1}", i, num[i]);
            }
            Console.ReadKey();
        }
    }
}
