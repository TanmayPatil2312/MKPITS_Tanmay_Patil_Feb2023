using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acc_with_polymorphism_form
{


    internal class saving : account
        {
          public  int interest = 500;
            public override int deposit(int amt)
            {
                bal = bal + amt + interest;
                return bal;
            }
        }
    
}
