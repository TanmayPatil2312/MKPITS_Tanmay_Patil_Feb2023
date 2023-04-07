using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_lvl_inher
{
    class person
    {
        public string name;
    }

    class student : person
    {
        public int rollno;
        public string branch;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s =new student();
            s.rollno = 23;
            s.branch = " MCA";
            s.name = "Sher";
            Console.WriteLine("Roll No : - " +  s.rollno);
            Console.WriteLine("Branch :- " + s.branch);
            Console.WriteLine("Name :- " + s.name);
            Console.ReadKey();
        }
    }
}
