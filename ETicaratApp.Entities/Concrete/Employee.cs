using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretApp.EntitiesLayer.Concrete;

namespace ETicaretApp.EntitiesLayer.Concrete
{
    public partial class Employee
    {
        [Key]
        public int EmployeesId { get; set; }

      
        public string Name { get; set; }
        public string Surname { get; set; }




       
        public virtual Department Department { get; set; }

        public virtual List<SellingAction> SellingActions { get; set; }
    }
}
