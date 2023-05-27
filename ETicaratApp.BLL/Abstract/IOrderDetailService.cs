using ETicaratApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Abstract
{
    public interface IOrderDetailService
    {
        void OrderDetailAdd(OrderDetail OrderDetail);

        void OrderDetailDelete(OrderDetail OrderDetail);

        void OrderDetailUpdate(OrderDetail OrderDetail);

        List<OrderDetail> GetList();

        OrderDetail GetById(int id);
    }
}
