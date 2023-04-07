using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class student
    {
        public string studname;
        public string address;
        public void getstudentdata(string studname, string address)
        {

            this.studname = studname;
            this.address = address;
        }
        public void displaypstudentdata()
        {

            Console.WriteLine("studname " + studname+ "\n");
            Console.WriteLine("stud address " + address + "\n");

        }


    }
    //inheriting a new child class from person class
    class placedstudent : student
    {

        public int studno;
        public int salary;
        public void getplacedstudentdata(int studno, int salary)
        {
            this.studno = studno;
            this.salary = salary;

        }
        public void displayplacedstudentdata()
        {
            Console.WriteLine("studno " + studno + "\n");
            Console.WriteLine("salary " + salary + "\n");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            placedstudent stud = new placedstudent();
            stud.getstudentdata("amitasha", "Raman Science Center");
            stud.getplacedstudentdata(456, 15000);
            stud.displayplacedstudentdata();
            stud.displayplacedstudentdata();
            Console.ReadKey();




        }
    }

}