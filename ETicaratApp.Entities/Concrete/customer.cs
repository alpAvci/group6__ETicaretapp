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
    public class Customer
    {
        [Key]

        public int CustomerId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string Surname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string Email { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string Password { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string Phone { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string City { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Country { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Address { get; set; }


        public SellingAction SellingAction { get; set; }

    }


}
