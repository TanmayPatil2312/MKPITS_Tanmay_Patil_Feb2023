using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_single_lvl_inher
{
    class person
    {
        public string name;
        public string address;
    }
    class employee : person
    {
        public int empno;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee empdetail = new employee();
            empdetail.empno = 23;
            empdetail.salary = 75000;
            empdetail.name = "Baburao Ganpatrao Apte ";
            empdetail.address = "Fortune Mall Sitabuli Nagpur";
            Console.WriteLine("empno :- " + empdetail.empno);
            Console.WriteLine("salary :- " + empdetail.salary);
            Console.WriteLine("name :- " + empdetail.name);
            Console.WriteLine("Address : - " + empdetail.address);
            Console.ReadKey();

        }
    }
}
