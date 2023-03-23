using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_define_method_display
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine(" Calling the Method display ");
            display();
            Console.WriteLine("Again Calling display");
            display();
            display1();
            Console.ReadLine();
        }
        static void display()
        {
            Console.WriteLine(" Hello World ");
        }
        static void display1()
        {
            Console.WriteLine(" Hello Fellows ");
        }
        
    }
    
}
