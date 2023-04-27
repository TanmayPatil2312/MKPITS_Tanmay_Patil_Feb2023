using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration_prog
{
    enum month
    {
        january , february , march , april , may, june , july , august , september , october , november , december
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the value of jan in month " + "enum is " + (int)month.january);
            Console.WriteLine("the value of jan in month " + "enum is " + (int)month.february);
            Console.WriteLine("the value of jan in month " + "enum is " + (int)month.march);
            Console.WriteLine("the value of jan in month " + "enum is " + (int)month.april);
            Console.WriteLine("the value of jan in month " + "enum is " + (int)month.may);
            Console.WriteLine("the value of jan in month " + "enum is " + (int)month.june);
            Console.WriteLine("the value of jan in month " + "enum is " + (int)month.july);
            Console.WriteLine("the value of jan in month " + "enum is " + (int)month.august);
            Console.ReadLine();
        }
    }
}
