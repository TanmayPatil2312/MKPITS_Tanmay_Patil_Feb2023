using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_lvl_inher_with_field
{
    public class employee
    {
        public float salary = 55000;
    }
    public class programmer : employee
    {
        public float bonus = 10000;
    }
    internal class Program
    {
        class testinheritance
        {


            static void Main(string[] args)
            {
                programmer p1 = new programmer();
                Console.WriteLine("Salary :- " + p1.salary);
                Console.WriteLine("Bonus :- " + p1.bonus);
                Console.ReadKey();
            }
        }
    }
}
