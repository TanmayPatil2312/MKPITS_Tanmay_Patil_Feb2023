using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feild_method_parameter_userinput
{
    //create a class student having field and method with parameters and
    //accept value from the user  and pass to class method

    class studdetail
    {
        int rollno;
        string name;

        public void getdata(int r , string n)
        {
            rollno = r;
            name = n;
        }
        public void displaydata()
        {
            Console.WriteLine("Roll no is " + rollno);
            Console.WriteLine(" Name is " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            studdetail stud1= new studdetail();
            Console.WriteLine(" Enter Roll No : - ");
            int rollno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name : - ");
            string name = Console.ReadLine();
            stud1.getdata(rollno, name);
            stud1.displaydata();
            Console.ReadKey();
        }
    }
}
