using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    public class Customer
    {
        [Key]

        public int CustomerId { get; set; }

        [Column (Type = "Varchar")]
        [StringLength(10)]
        public string Name { get; set; }

        [Column(Type = "Varchar")]
        [StringLength(15)]
        public string Surname{ get; set; }

        [Column(Type = "Varchar")]
        [StringLength(20)]
        public string Email { get; set; }

        [Column(Type = "Varchar")]
        [StringLength(15)]
        public string Password { get; set; }


        [Column(Type = "Varchar")]
        [StringLength(15)]
        public string Phone { get; set; }

        [Column(Type = "Varchar")]
        [StringLength(10)]
        public string City { get; set; }


        [Column(Type = "Varchar")]
        [StringLength(10)]
        public string Country { get; set; }

        [Column(Type = "Varchar")]
        [StringLength(100)]
        public string Address { get; set; }

        

        
    }
    }
    }
}
