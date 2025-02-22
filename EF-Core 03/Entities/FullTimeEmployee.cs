using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_03.Entities
{
    internal class FullTimeEmployee : Employees
    {
        public double Salary { get; set; }
    }
}
