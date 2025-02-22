using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_02.Entities
{
    public class Employee
    {
        public int EmpId { get; set; }

        public string Name { get; set; }


        public int? Age { get; set; }


        public string Address { get; set; }


        public double Salary { get; set; }


        public DateTime HiringDate { get; set; } = DateTime.UtcNow;

        public int DeptId { get; set; }

        public virtual Department WorkFor { get; set; }



    }
}
