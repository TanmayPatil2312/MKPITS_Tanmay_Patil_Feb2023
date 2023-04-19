using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical1_exmp
{
    public class person
    {
        string name;
        string address;
        public void getPersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonalData()
        {
            Console.WriteLine("name :- " + name);
            Console.WriteLine("address : - " + address);
        }
    }
    public class student : person
    {
        int rollno;
        int mark;
        public void getStudentData(int rollno, int mark)
        {
            this.rollno = rollno;
            this.mark = mark;
        }
        public void displayStudentData()
        {
            Console.WriteLine("Roll No :- " + rollno);
            Console.WriteLine("mark : - " + mark);
        }
    }
    public class employee : person
    {
        int salary;
        string designation;
        public void getEmployeeData(int salary , string designation)
        {
            this.salary = salary;
            this.designation = designation;
        }
        public void displayEmployeeData()
        {
            Console.WriteLine("salary : - " + salary);
            Console.WriteLine("designation : - " + designation);
        }
    }
    class testinheritance
    {
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student p1 = new student();
            p1.getPersonData(" tanmay ", " Pune ");
            p1.getStudentData(101, 231);
            p1.displayPersonalData();
            p1.displayStudentData();
            Console.ReadLine();


            //creating object of employee class
            employee e1 = new employee();
            e1.getPersonData(" Viyaan ", " Mumbai ");
            e1.getEmployeeData(755, " Manager ");
            e1.displayPersonalData();
            e1.displayEmployeeData();
            Console.ReadLine();
        }
    }
}
