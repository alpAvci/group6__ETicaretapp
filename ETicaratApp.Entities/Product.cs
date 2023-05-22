using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
       
        
        
        public short ProductStock  { get; set; }
        public short SellingPrice { get; set; }
        public bool IsStock { get; set; }

       
        [Column(TypeName = "Varchar")]
        [StringLength(40)]
        public string ProducktImage { get; set; }

    }
}
