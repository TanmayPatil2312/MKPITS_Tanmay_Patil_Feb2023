using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, count = 1, number;
            Console.Write("Enter number of rows:");
           
            number = int.Parse(Console.ReadLine());
            for (j = 1; j <= number - 1; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - j) - 1; i++)
                    Console.Write("$");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
