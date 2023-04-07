using System;

// create a class student having fields rno and name and
// create a default constructor (without  parameters )and display method
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class studentdetail
    {
        int rollno;
        string name;
        //creating a constructor
        public studentdetail()
        {
            rollno = 999;
            name = "Dani Daniel";
        }
        public void displaydata()
        {

            Console.WriteLine("Roll no :-  " + rollno);
            Console.WriteLine("Name :- " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            studentdetail stud1 = new studentdetail();// it will call constructor

            stud1.displaydata();
            Console.ReadKey();
        }
    }
}
