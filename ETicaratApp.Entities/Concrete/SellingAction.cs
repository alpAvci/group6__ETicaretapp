using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities.Concrete;

namespace ETicaratApp.Entities
{
    public partial class SellingAction
    {
        [Key]
        public int SellingId { get; set; }
        
        
        public  DateTime Date  { get; set; }
        public int Unit { get; set; }
        public int TotalCost { get; set; }

        public ICollection<Product>  Products { get;}
        public ICollection<Customer> Customers  { get;}
        public ICollection<Employee> Employees  { get;}






    }
}
