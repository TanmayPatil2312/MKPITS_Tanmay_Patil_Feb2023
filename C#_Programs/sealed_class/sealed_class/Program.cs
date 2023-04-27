using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class
{
    sealed class employee
    {
        public void showdata()
        {
            Console.WriteLine("hello rani ");
        }
    }
    class pmp employee
     {
     }
       

        static void Main(string[] args)
        {
            employee emp=new employee();
            emp.showdata();
        }
    }

