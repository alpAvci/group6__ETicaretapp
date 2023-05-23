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
    public class Product
    {
        [Key] 
        public int ProductId { get; set; }

        [Column(TypeName="Varchar")]
        [StringLength(40)]
        public string ProductName  { get; set; }

       
        
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string ProductBrand  { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string color { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string size { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string ProductDescription { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(300)]
        public string ProductFeatur { get; set; }
        public short ProductStock  { get; set; }
        public short Discount { get; set; }
        public decimal SellingPrice { get; set; }
        public bool IsStock { get; set; }

       
        [Column(TypeName = "Varchar")]
        [StringLength(270)]
        public string ProducktImage { get; set; }


        public SellingAction SellingAction { get; set; }
        public Category Category { get; set; }
        

    }
}
