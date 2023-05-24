using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    public class Payment
    {
        [Key]
        public int CustomerId { get; set; }


        public ICollection<PaymentMethod> PaymentMethods { get; set; }
        



    }
}
