using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretApp.EntitiesLayer.Concrete;

namespace ETicaretApp.EntitiesLayer.Concrete
{


    public partial class Order
    {

        [Key]
        public int OrderId { get; set; }

        //[ForeignKey("Customer")]
        public int CustomerID { get; set; }

        //[ForeignKey("Payment")]
        public int PaymentId { get; set; }
        public int EmployeeId { get; set; }




        public string OrderNumber { get; set; }
        public string Name { get; set; }
        public string sername { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string ErrLoc { get; set; }
        public string ErrMsg { get; set; }



        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
        public virtual Payment Payment { get; set; }





    }




}