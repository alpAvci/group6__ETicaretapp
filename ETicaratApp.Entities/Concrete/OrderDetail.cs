using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretApp.EntitiesLayer.Concrete;
using System.Security.Cryptography.X509Certificates;

namespace ETicaretApp.EntitiesLayer.Concrete
{
    public  partial class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        //[ForeignKey("Product")]
        public int ProductId { get; set; }
        //[ForeignKey("Order")]
        public int OrderId { get; set; }


        public string OrderNumber { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; } 
        public double Discount  { get; set; }
        public decimal Total { get; set;}
        public string color { get; set; }
        public string size { get; set; }
        public bool OrderStatus { get; set; }






        public Order Order { get; set; }
        public virtual Product Product { get; set; }





    }
}
