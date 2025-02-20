using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assigment01.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double? Bouns { get; set; }


        public double Salary { get; set; }


        public string Address { get; set; }


        public double HourRate { get; set; }


        public int Dept_Id { get; set; }
    }
}
