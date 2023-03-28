using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_string_program
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] stringarr = new string[] {"Friends", "Forever" , "tanmay", "jayesh" ," sahil", "yasmin"};
            stringarr[0] = "Friends";
            stringarr[1] = "Forever";
            stringarr[2] = "tanmay";
            stringarr[3] = "jayesh";
            stringarr[4] = "sahil";
            stringarr[5] = "yasmin";

           
            foreach (string val in stringarr)
            {
                Console.WriteLine(" string Value is  = " + val);
                Console.ReadKey();
            }
        }
    }
}




