using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class Class1
    {
        public string addition (int n1,int n2)
        {
            int result = n1 + n2;
            return "addition is " + result.ToString();
        }

        public string substraction(int n1, int n2)
        {
            int result = n1 - n2;
            return "substraction is " + result.ToString();
        }

        public string multiplication(int n1, int n2)
        {
            int result = n1 * n2;
            return "multiplication is " + result.ToString();
        }

        public string division(int n1, int n2)
        {
            int result = n1 / n2;
            return "division is " + result.ToString();
        }
    }
}
