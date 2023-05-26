using ETicaratApp.Entities;
using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.DAL.Repostories
{
    public class PaymentRepostory : IPaymentDal
    {
        Context py = new Context();
        public void AddPayment(Payment payment)
        {
            py.Add(payment);
            py.SaveChanges();
        }

        public void DeletePayment(Payment payment)
        {
            py.Remove(payment);
            py.SaveChanges();
        }

        public Payment GetById(int Id)
        {
            return py.Payments.Find(Id);
        }

        public List<Payment> ListAllPayment()
        {
            return py.Payments.ToList();
        }

        public void UpdatePayment(Payment payment)
        {
           py.Update(payment);
            py.SaveChanges();
        }
    }
}
