using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities.Concrete
{
    public partial class Customer
    {
        [Key]
        public int CustomerId { get; set; }

       
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; } 
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }


        public SellingAction SellingAction { get; set; }
        public virtual ICollection<Order> Orders { get;}=new List<Order>();
    }


}
