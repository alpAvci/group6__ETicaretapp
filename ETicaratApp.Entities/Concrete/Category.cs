using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretApp.EntitiesLayer.Concrete;

namespace ETicaretApp.EntitiesLayer.Concrete
{
    public partial class Category
    {
        [Key]
        public int CategoryId { get; set; }
           public int ProductId { get; set; }
        
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public virtual List<Product> Products { get; set; }

    }
}
