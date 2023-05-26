using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities;

namespace ETicaretApp.DAL.Abstarct
{
    public interface IPaymentDal
    {
        List<Payment> ListAllPayment();
        void AddPayment(Payment payment);

        void DeletePayment(Payment payment);

        void UpdatePayment(Payment payment);

        Payment GetById(int Id);
    }
}
