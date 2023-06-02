using ETicaretApp.EntitiesLayer.Concrete;
using ETicaretApp.BLL.Abstract;
using ETicaretApp.DAL.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Concrete
{
    public class PaymentMethodManager : IPaymentMethodService
    {
        IPaymentMethodDal _PaymentMethodDal;

        public PaymentMethodManager(IPaymentMethodDal paymentMethodDal)
        {
            _PaymentMethodDal = paymentMethodDal;
        }

        public PaymentMethod GetById(int id)
        {
            return _PaymentMethodDal.GetByID(id);
        }

        public List<PaymentMethod> GetList()
        {
           return _PaymentMethodDal.getListAll();
        }

        public void PaymentMethodAdd(PaymentMethod PaymentMethod)
        {
            _PaymentMethodDal.insert(PaymentMethod);
        }

        public void PaymentMethodDelete(PaymentMethod PaymentMethod)
        {
            _PaymentMethodDal.delete(PaymentMethod);
        }

        public void PaymentMethodUpdate(PaymentMethod PaymentMethod)
        {
            _PaymentMethodDal.update(PaymentMethod);
        }
    }
}
