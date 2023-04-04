using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stud_feild_method_parameter
{
    // create  a class student having fields and method with parameters
    class studdetail
    {
        int rollno;
        string name;

        // creating member functions

        public void getdata(int r , string n)
        {
            rollno = r;
            name = n;
        }

        public void displaydata()
        {
            Console.WriteLine(" Roll no is " + rollno);
            Console.WriteLine(" Name is " + name);
            Console.ReadKey();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            studdetail stud1 = new studdetail();
            stud1.getdata(69, "Rosheal");
            stud1.displaydata();
        }
    }
}
