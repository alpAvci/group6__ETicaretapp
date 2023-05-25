using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities.Concrete;

namespace ETicaratApp.Entities
{
    public partial class Product
    {
        [Key] 
        public int ProductId { get; set; }
        
        //[ForeignKey("Category")]
        public int CategoryId { get; set; }

        
 
        public string ProductName  { get; set; }
        public string ProductBrand { get; set; } 
        public string color { get; set; }
        public string size { get; set; }
        public string ProductDescription { get; set; }   
        public string ProductFeatur { get; set; }
        public int UnitPrice { get; set; }
        public short ProductStock  { get; set; }
        public short Discount { get; set; }

        public bool? DiscountAvailable { get; set; }
        public bool? CurrentOrder { get; set; }
        public decimal SellingPrice { get; set; }
        public bool IsStock { get; set; }
        public string ProducktImage { get; set; }


        
        
        
        
        
       
        
        public SellingAction SellingAction { get; set; }
        
        public virtual Category Category { get; set; }

        public virtual List<OrderDetail> OrderDetail { get; set; }


    }
}
