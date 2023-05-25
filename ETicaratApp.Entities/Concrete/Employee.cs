using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    public partial class Employee
    {
        [Key]
        public int EmployeesId { get; set; }

      
        public string Name { get; set; }
        public string Surname { get; set; }




       
        public virtual Department Department { get; set; }

    }
}
