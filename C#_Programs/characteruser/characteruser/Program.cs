using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characteruser
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a program to accept character from the user
            char ch;

            Console.WriteLine("enter character ");

            ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("character entered is = " + ch);

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}


   

