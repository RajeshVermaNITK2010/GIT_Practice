using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Employee
    {
        public virtual decimal Bonus { get { return 0m; } }
    }

    public class Manager : Employee
    {
        public override decimal Bonus { get { return 10000m; } }
    }

    
   
}

