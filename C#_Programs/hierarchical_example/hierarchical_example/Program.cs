using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_example
{
    class person
    {
        public string name;
        public string address;
    }
    class student : person
    {
        public int rollno;
        public int mark;
    }
    class employee : person
    {
        public int salary;
        public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating object of student class
            student stud = new student();
            stud.name = "Baburao";
            stud.address = "Fortune Mall";
            stud.rollno = 23;
            stud.mark = 65;
            Console.WriteLine(" ------- student details -----  ");
            Console.WriteLine("name :- " + stud.name);
            Console.WriteLine("Address :- " + stud.address);
            Console.WriteLine("Roll No :- " + stud.rollno);
            Console.WriteLine("Mark : - " + stud.mark);
            Console.ReadLine();

            // creating object of employee class 
            employee emp = new employee();
            emp.name = " Sham";
            emp.address = "Inox Mall";
            emp.salary = 55000;
            emp.designation = "Senior Developer";
            Console.WriteLine(" -------- employee details ------- ");
            Console.WriteLine(" Name : - " + emp.name);
            Console.WriteLine(" Address :- " + emp.address);
            Console.WriteLine("Salary :- " + emp.salary);
            Console.WriteLine("Designation :- " + emp.designation);
            Console.ReadLine();

        }
    }
}
