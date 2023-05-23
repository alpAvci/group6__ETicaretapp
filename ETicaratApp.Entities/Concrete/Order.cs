using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities.Concrete;

namespace ETicaratApp.Entities
{
    internal class Order
    {
        public int OrderId { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string OrderName { get; set; }

        public DateTime OrderDate { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string OrderStatus { get; set; }



        [Column(TypeName = "Varchar")]
        [StringLength(15)]
        public string ErrLoc { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(15)]       
        public string ErrMsg { get; set; }






        public Customer Customer { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public ICollection<Product> Products { get; set; }



        
    }
}
