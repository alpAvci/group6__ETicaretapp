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
    internal class OrderDetail
    {


        public int OrderDetailId { get; set; }

        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        
        public double Discount  { get; set; }

        public decimal Total { get; set;}


        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string color { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string size { get; set; }





        public Customer Customer { get; set; }
        public Order Order { get; set; }

        public ICollection<Product> Products { get; set; }



    }
}
