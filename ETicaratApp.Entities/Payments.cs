using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.Entities
{
    internal class Payments
    {
        public int CustomerId { get; set; }


        public ICollection<PaymentMethod> PaymentMethods { get; set; }
        



    }
}
