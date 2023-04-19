using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion1
{
    internal class Program
    {
        static void Main()
        {
            int res = myfunct(5, 3);
            Console.WriteLine(res);
            Console.ReadLine();

        }
        static int myfunct(int x , int y)
        {
            if(y<=0)
            {
                return 1;
            }
            else
            {
                return x * myfunct(x, y - 1);
            }
        }
    }
}
