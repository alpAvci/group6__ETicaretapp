using ETicaretApp.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Abstract
{
    public interface IPaymentService
    {
        void PaymentAdd(Payment Payment);

        void PaymentDelete(Payment Payment);

        void PaymentUpdate(Payment Payment);

        List<Payment> GetList();

        Payment GetById(int id);
    }
}
