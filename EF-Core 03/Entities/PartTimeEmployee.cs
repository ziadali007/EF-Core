﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_03.Entities
{
    internal class PartTimeEmployee : Employee
    {
        public int NumberOfHours { get; set; }

        public double HourRate { get; set; }
    }
}
