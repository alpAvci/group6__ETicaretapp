using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretApp.EntitiesLayer.Concrete;

namespace ETicaretApp.EntitiesLayer.Concrete
{
    public partial class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        


        public  string PaymentType { get; set; }


        
        public Order Order { get; set; }



    }
}
