using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeesId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
