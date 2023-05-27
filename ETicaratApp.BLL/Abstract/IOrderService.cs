using ETicaratApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Abstract
{
    public interface IOrderService
    {
        void OrderAdd(Order Order);

        void OrderDelete(Order Order);

        void OrderUpdate(Order Order);

        List<Order> GetList();

        Order GetById(int id);
    }
}
