using ETicaratApp.Entities;
using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Repostories
{
    public class OrderRepostory : IOrderDal
    {
        Context or = new Context();
        public void AddOrder(Order order)
        {
            or.Add(order);
            or.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            or.Remove(order);
            or.SaveChanges();
        }

        public Order GetById(int Id)
        {
            return or.Orders.Find(Id);

        }

        public List<Order> ListAllOrder()
        {   
            return or.Orders.ToList();
        }

        public void UpdateOrder(Order order)
        {
            or.Update(order);
            or.SaveChanges();
        }
    }
}
