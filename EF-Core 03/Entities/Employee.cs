﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_03.Entities
{
    internal abstract class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }


        public string? Email { get; set; }


        public string? Address { get; set; }
    }
}
