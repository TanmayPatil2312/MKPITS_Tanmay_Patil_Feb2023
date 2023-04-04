using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stud_class_object
{
    //create class student
    class studdetail
    {
        public int rollno;
         public string name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            studdetail stud1= new studdetail();
            stud1.rollno = 69;
            stud1.name = "rosheal";
            Console.WriteLine("Roll no is " + stud1.rollno);
            Console.WriteLine(" Name is  " + stud1.name);
            Console.ReadKey();
        }
    }
}
