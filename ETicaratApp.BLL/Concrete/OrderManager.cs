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
    public class OrderManager : IOrderService
    {
        IOrderDal _OrderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _OrderDal = orderDal;
        }

        public Order GetById(int id)
        {
            return _OrderDal.GetByID(id);
        }

        public List<Order> GetList()
        {
            return _OrderDal.getListAll();
        }

        public void OrderAdd(Order Order)
        {
            _OrderDal.insert(Order);
        }

        public void OrderDelete(Order Order)
        {
            _OrderDal.delete(Order);
        }

        public void OrderUpdate(Order Order)
        {
            _OrderDal.update(Order);
        }
    }
}
