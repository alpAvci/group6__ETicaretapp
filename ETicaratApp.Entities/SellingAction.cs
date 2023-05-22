using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    internal class SellingAction
    {
        [Key]
        public int SellingId { get; set; }
        
        
        public  DateTime Date  { get; set; }
        public int Unit { get; set; }
        public int TotalCost { get; set; }

    }
}
