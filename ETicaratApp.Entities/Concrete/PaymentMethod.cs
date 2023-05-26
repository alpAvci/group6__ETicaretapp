using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    public partial class PaymentMethod
    {
        
        [Key]
        public int PaymentMethodId { get; set; }

        public int  paymentId { get; set; }




    }
}
