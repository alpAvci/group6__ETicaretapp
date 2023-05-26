using ETicaratApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Abstarct
{
    public interface IOrderDal
    {

        List<Order> ListAllOrder();
        void AddOrder(Order order);

        void DeleteOrder(Order order);

        void UpdateOrder(Order order);

        Order GetById(int Id);

    }
}
