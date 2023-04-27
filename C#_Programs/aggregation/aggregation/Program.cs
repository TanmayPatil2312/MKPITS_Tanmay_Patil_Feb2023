using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{

    class address
    {
        public string city;
        public string state;
        public address (string city, string state)
        {
            this.city = city;
            this.state = state;
        }
    }
    class employee
    {
        int emp_no;
        string name;
        address add; // has 

        public employee (int emp_no, string name, address add)
        {
            this.emp_no = emp_no;
            this.name = name;
            this.add = add;
        }
        public void display()
        {
            Console.WriteLine(emp_no);
            Console.WriteLine(name);
            Console.WriteLine(add.city);
            Console.WriteLine(add.state);
            Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            address a1=new address("NGP","MH");
            employee emp = new employee(23, "Rani",a1);
            emp.display();
        }
    }
}
