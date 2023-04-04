using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 using System;
    //system is a namespace
    //namespace is a unit to group related classes, packages

    namespace stud_detail

    {
        class Program
        {
            static void Main()
            {
                int rollno, age;
                 double mobno;
                string name, course;

                Console.WriteLine("please enter rollno :-");
                rollno = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("please enter name:-");
                name = Console.ReadLine();


                 Console.WriteLine("please enter age :-");
                age = Convert.ToInt32(Console.ReadLine());


                 Console.WriteLine("please enter course:-");
                 course = Console.ReadLine();


                Console.WriteLine("please enter mobno :-");
                mobno = Convert.ToDouble(Console.ReadLine());

                 Console.WriteLine("Roll no is  :-" + rollno);
                  Console.WriteLine("Name is :-" + name);
                  Console.WriteLine("Age is  :-" + age);
                  Console.WriteLine("Course is :- " + course);
                  Console.WriteLine("Mob no is  :- " + mobno);


            Console.ReadKey();
            }
        }
    }



