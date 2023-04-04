using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rank_len_progam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a num array of 2 rows and 3 colums 
            int[,] num = new int[2, 3];
            for( int i=0; i<2; i++)
            {
                for( int j=0; j<3; j++)
                {
                    Console.WriteLine(" Enter Number ");
                    num[i,j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            // display the value of array
            for (int i=0; i<2; i++)
            {
                for (int j=0; j<3; j++)
                {
                    Console.Write(num[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("rank " + num.Rank);
            Console.WriteLine("length " + num.Length);
        }
        
    }
}
