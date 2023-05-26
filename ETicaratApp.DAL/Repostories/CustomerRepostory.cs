using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities.Concrete;
using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Concrete;

namespace ETicaretApp.DAL.Repostories
{
    public class CustomerRepostory : ICustomerDal
    {
        Context cs = new Context();
        public void AddCustomer(Customer customer)
        {
            cs.Add(customer);
            cs.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            cs.Remove(customer);
            cs.SaveChanges();
        }

        public Customer GetById(int Id)
        {
            return cs.Customers.Find(Id);
        }

        public List<Customer> ListAllCustomer()
        {
            return cs.Customers.ToList();
        }

        public void UpdateCustomer(Customer customer)
        {
            cs.Update(customer);
            cs.SaveChanges();
        }
    }
}
