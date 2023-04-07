using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class this_keyword
    {
        int rollno;
        string name;
        //creating member functions
        public void getdata(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public void displaydata()
        {

            Console.WriteLine("Roll no:-  " + rollno);
            Console.WriteLine("Name :- " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            this_keyword stud1 = new this_keyword();
            Console.WriteLine("Enter rollno :- ");
            int rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name :- ");
            string name = Console.ReadLine();

            stud1.getdata(rollno, name);
            stud1.displaydata();
            Console.ReadKey();
        }
    }
}
