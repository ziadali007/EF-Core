using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_02.Entities
{
    public class Department
    {
        public int Id { get; set; }

        public string DeptName { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}
