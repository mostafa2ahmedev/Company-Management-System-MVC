﻿using El_sheikh.MVC.DAL.Entities.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_sheikh.MVC.DAL.Entities.Departments
{
   // Department is a model base
    public class Department: ModelBase
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Description { get; set; } = null!;

        public DateOnly CreationDate { get; set; } // business wise 


        // Navigational property many
        public virtual ICollection<Employee> Employee { get; set; } = new HashSet<Employee>();


    }
}
