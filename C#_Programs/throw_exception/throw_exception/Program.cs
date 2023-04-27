using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace throw_exception
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            try
            {
                Console.WriteLine("Enter Your Age");
                age = Convert.ToInt32(Console.ReadLine());
                if (age<=0||age>100)
                {
                    throw new Exception("Enter Correct Age");
                }
                else
                {
                    Console.WriteLine("Your Age is " + age);
                }
            }
            catch (Exception AB) 
            {
                Console.WriteLine(AB.ToString());
            }
            Console.WriteLine("BYe fellows");
            Console.ReadLine();
        }
    }
}
