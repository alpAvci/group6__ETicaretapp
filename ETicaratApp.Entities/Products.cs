using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    public class Products
    {
        [Key] 
        public int ProductId { get; set; }


        public string ProductName  { get; set; }
        public string ProductBrand  { get; set; }
        public short ProductStock  { get; set; }
        public short SellingPrice { get; set; }
        public bool IsStock { get; set; }
        public string ProducktImage { get; set; }

    }
}
