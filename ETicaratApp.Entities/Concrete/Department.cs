using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    public partial class Department
    {
        [Key]
        public int DepartmentId { get; set; }

       
        public string DepartmentName { get; set; }


       public virtual List<Employee> Employees { get; set; }
        public virtual SellingAction SellingAction { get; set; }

    }
}
