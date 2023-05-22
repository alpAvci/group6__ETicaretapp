using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(Type = "Varchar")]
        [StringLength(15)]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set;}

    }
}
