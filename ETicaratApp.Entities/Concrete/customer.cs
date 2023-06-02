using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ETicaretApp.EntitiesLayer.Concrete;

namespace ETicaretApp.EntitiesLayer.Concrete
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


        public virtual List<SellingAction> SellingActions { get; set; }
        public virtual List<Order> Order { get; set; }

        public virtual  List<Comment> Comments { get; set; }

        public virtual List<Product> Products { get; set; }

    }


}
