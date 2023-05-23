using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string DepartmentName { get; set; }


        public ICollection<Employee> Employees { get; set; }
    }
}
