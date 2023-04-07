using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_with_parameter
{
    class studentdetail
    {
        int rollno;
        string name;
        //creating a constructor
        public studentdetail()
        {
            rollno = 999;
            name = "kamlesh";
        }
        //creating a constructor with parameters
        public studentdetail(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;

        }
        public void displaydata()
        {

            Console.WriteLine("Roll no :- " + rollno);
            Console.WriteLine("name " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            studentdetail stud1 = new studentdetail();// it will call constructor with no parameters

            stud1.displaydata();

            Console.WriteLine("Enter Rollno ");
            int rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            studentdetail stud2 = new studentdetail(rollno, name);//will call constructor with parameters
            stud2.displaydata();
            Console.ReadKey();
        }
    }

}
