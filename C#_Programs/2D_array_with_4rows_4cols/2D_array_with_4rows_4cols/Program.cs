using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_array_with_4rows_4cols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating a num array of 2 rows and 3 colums
            // int [] num = new int [5] {1,2,3,4,5};
            int[,] num = { { 1, 2, 3, 4 }, { 5,6,7,8 } ,{ 9,10,11,12}, {13,14,15,16 } };

            //display the values of array

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(num[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
