using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities.Concrete
{
    public partial class Category
    {
        [Key]
        public int CategoryId { get; set; }

        
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public virtual ICollection<Product> Products { get; } = new List<Product>();

    }
}
