using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities;
using ETicaratApp.Entities.Concrete;

namespace ETicaretApp.BLL.Abstract
{
    public interface ICustomerService
    {
        void CustomerAdd(Customer customer);

        void CustomerDelete(Customer customer);

        void CustomerUpdate(Customer customer);

        List<Customer> GetList();

        Customer GetById(int id);
    }
}
