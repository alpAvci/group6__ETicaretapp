using ETicaratApp.Entities;
using ETicaretApp.BLL.Abstract;
using ETicaretApp.DAL.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _PaymentDal;

        public PaymentManager(IPaymentDal payment)
        {
            _PaymentDal = payment;
        }

        public Payment GetById(int id)
        {
            return _PaymentDal.GetByID(id);
        }

        public List<Payment> GetList()
        {
            return _PaymentDal.getListAll();
        }

        public void PaymentAdd(Payment Payment)
        {
            _PaymentDal.insert(Payment);
        }

        public void PaymentDelete(Payment Payment)
        {
            _PaymentDal.delete(Payment);
        }

        public void PaymentUpdate(Payment Payment)
        {
            _PaymentDal.update(Payment);
        }
    }
}
