using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pass_by_value_using_in
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("value of num inside main before passing " + num);

            display(num);
            Console.WriteLine(" value of num after calling  " + num);
            Console.ReadKey();
        }
        static void display(int num)
        {
            num = num + 2;
            Console.WriteLine(" value of num inside display " + num);
        }
    }
}
