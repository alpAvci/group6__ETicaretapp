using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities.Concrete;

namespace ETicaratApp.Entities
{
    public partial class SellingAction
    {
        [Key]
        public int SellingId { get; set; }
        
        public int ProductId { get; set; }
        
        public  DateTime Date  { get; set; }
        public int Unit { get; set; }
        public int TotalCost { get; set; }

        public virtual Product Product { get; set; }
       
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }






    }
}
