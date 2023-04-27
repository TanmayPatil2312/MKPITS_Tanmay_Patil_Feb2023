using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_field
{
    class Employee
    {
        public int emp_no;
        public string name;
        public static string company_name;
        public Employee(int emp_no, string name)
        {
            this.emp_no = emp_no;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Emp_No : - " + emp_no);
            Console.WriteLine("Name :- " + name);
            Console.WriteLine("Company Name :- " + company_name);
            Console.ReadLine();
        }
    }
    internal class program
    {

        static void Main(string[] args)
        {
            Employee a1 = new Employee(156, " Rani ");
            Employee a2 = new Employee(5656, " weds ");
            Employee a3 = new Employee(256, "Jayesh");

            a1.display();
            a2.display();
            a3.display();
        }
    }
}


