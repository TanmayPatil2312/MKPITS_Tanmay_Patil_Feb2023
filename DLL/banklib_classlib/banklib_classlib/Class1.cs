using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banklib_classlib
{
    public class Class1
    {
        int bal = 1000;
        public string deposit(int amount)
        {
            int total = bal + amount;
            return "bal is " + total.ToString();
        }

        public string withdrawal(int withdrawal)
        {
            int total = bal - withdrawal;
            return "withdrawal is " + total.ToString();
        }


    }
}
