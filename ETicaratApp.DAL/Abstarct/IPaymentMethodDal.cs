using ETicaratApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Abstarct
{
    public interface IPaymentMethodDal
    {
        List<PaymentMethod> ListAllPaymentMethod();
        void AddPaymentMethod(PaymentMethod paymentmethod);

        void DeletePaymentMethod(PaymentMethod paymentmethod);

        void UpdatePaymentMethod(PaymentMethod paymentmethod);

        PaymentMethod GetById(int Id);

    }
}
