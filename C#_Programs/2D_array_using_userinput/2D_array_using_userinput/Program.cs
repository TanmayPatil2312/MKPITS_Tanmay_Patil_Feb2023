using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_array_using_userinput
{
    internal class Program
    {
        static void Main()
        {
            int[,] num = new int[3, 2];
            for(int i=0; i<3; i++)
            {
                for (int j=0; j<2; j++)
                {
                    Console.WriteLine(" Enter Number ");
                    num[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //display the value of array
            for(int i=0;i<3;i++)
            {
                for(int j=0; j<2; j++)
                {
                    Console.Write( num[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
