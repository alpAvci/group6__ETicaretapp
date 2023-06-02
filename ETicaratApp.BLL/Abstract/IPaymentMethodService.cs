using ETicaretApp.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Abstract
{
    public interface IPaymentMethodService
    {
        void PaymentMethodAdd(PaymentMethod PaymentMethod);

        void PaymentMethodDelete(PaymentMethod PaymentMethod);

        void PaymentMethodUpdate(PaymentMethod PaymentMethod);

        List<PaymentMethod> GetList();

        PaymentMethod GetById(int id);
    }
}
