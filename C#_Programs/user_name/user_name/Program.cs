using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_name
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //to declare variable : datatype variable name
            string name;

            Console.WriteLine("please enter your name dear");
            name = Console.ReadLine();
            Console.WriteLine("hello mr/miss " + name);
            Console.ReadKey();
        }
    }
}
