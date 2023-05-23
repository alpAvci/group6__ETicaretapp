﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeesId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Name { get; set; }

        [Column(TypeName = " varchar")]
        [StringLength(15)]
        public string Surname { get; set; }

        public Employee employee { get; set; }
       
    }
}