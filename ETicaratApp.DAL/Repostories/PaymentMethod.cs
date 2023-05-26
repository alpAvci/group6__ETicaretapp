using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.DAL.Repostories
{
    public class PaymentMethod : IPaymentMethodDal
    {
        Context pm = new Context();
        public void AddPaymentMethod(Entities.PaymentMethod paymentmethod)
        {
            pm.Add(paymentmethod);
            pm.SaveChanges();
        }

        public void DeletePaymentMethod(Entities.PaymentMethod paymentmethod)
        {
            pm.Remove(paymentmethod);
            pm.SaveChanges();
        }

        public Entities.PaymentMethod GetById(int Id)
        {
            return pm.PaymentMethods.Find(Id);

        }

        public List<Entities.PaymentMethod> ListAllPaymentMethod()
        {
            return pm.PaymentMethods.ToList();
        }

        public void UpdatePaymentMethod(Entities.PaymentMethod paymentmethod)
        {
            pm.Update(paymentmethod);
            pm.SaveChanges();
        }
    }
}
