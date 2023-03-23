using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_sub_marks_per_grade
{
    internal class stud_result
    {
        static void Main(string[] args)
        {
            // WAP tp accept 3 subjects marks and print total , percentage , grade.

            int s1, s2, s3, total;
            float per;
            string grade = "";
            Console.WriteLine("Enter Subject 1 Mark ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Subject 2 Mark ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Subject 3 Mark ");
            s3 = Convert.ToInt32(Console.ReadLine());
            total = s1 + s2 + s3;
            Console.WriteLine("total = " + total + "\n");
            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("percentage = " + per + "\n");

            if (per >= 75)
            {
                grade = "distinction";
            }
            else if (per >= 60 && per < 75)
            {
                grade = " first";
            }
            else
            {
                grade = "fail";
            }
            Console.WriteLine("Grade = " + grade + "\n");
            Console.ReadKey();

        }
    }
}
