using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_using_field_method
{
    // create a class student having fields and methods
    class studdetail

    {
        int rollno;
        string name;
    
        public void getdata()
        {
        rollno = 69;
        name = "rosheal";
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
            studdetail stud1= new studdetail();
            stud1.getdata();
            stud1.displaydata();

        }
    }
}
