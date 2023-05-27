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
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _OrderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _OrderDetailDal = orderDetailDal;
        }

        public OrderDetail GetById(int id)
        {
            return _OrderDetailDal.GetByID(id);
        }

        public List<OrderDetail> GetList()
        {
            return _OrderDetailDal.getListAll();
        }

        public void OrderDetailAdd(OrderDetail OrderDetail)
        {
            _OrderDetailDal.insert(OrderDetail);
        }

        public void OrderDetailDelete(OrderDetail OrderDetail)
        {
            _OrderDetailDal.delete(OrderDetail);
        }

        public void OrderDetailUpdate(OrderDetail OrderDetail)
        {
            _OrderDetailDal.update(OrderDetail);
        }
    }
}
