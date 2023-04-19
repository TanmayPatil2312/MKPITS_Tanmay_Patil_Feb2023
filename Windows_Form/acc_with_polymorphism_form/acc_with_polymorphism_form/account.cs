using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acc_with_polymorphism_form
{
     internal class account
    {
        public int bal = 1000;
        public virtual int deposit(int amt)
        {
            return bal;
        }
    }
}
