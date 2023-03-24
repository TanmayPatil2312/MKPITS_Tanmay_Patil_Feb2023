using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
            int counter; 
            int isprime = 0;

            for(counter=1; counter<=7; counter++)

            {
                if(num%counter==0)
                {
                    isprime = 1;
                    break;
                }
            }
            if(isprime==0)
            {
                Console.WriteLine("It is a Prime no. ");
            }
            else 
            {
                Console.WriteLine("It is not a prime no.  ");
            }
            Console.ReadKey();
        }
    }
}
