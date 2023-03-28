using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_char_program
{
    internal class Program
    {

        static void Main(string[] args)
        {
            char[] arr = new char[15];
            arr[0] = 'J';
            arr[1] = 'a';
            arr[2] = 'y';
            arr[3] = 'e';
            arr[4] = 's';
            arr[5] = 'h';

            arr[6] = 'W';
            arr[7] = 'o';
            arr[8] = 'r';
            arr[9] = 'k';

            arr[10] = 'H';
            arr[11] = 'a';
            arr[12] = 'r';
            arr[13] = 'd';
            arr[14] = 's';
            foreach (char val in arr)
            {
                Console.WriteLine(" char Value is  = " + val);
                Console.ReadKey();
            }
        }
    }
}



