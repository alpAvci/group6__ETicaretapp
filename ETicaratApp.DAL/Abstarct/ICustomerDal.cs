using ETicaratApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Abstarct
{
    public interface ICustomerDal
    {

        List<Customer> ListAllCustomer();
        void AddCustomer( Customer customer);

        void DeleteCustomer(Customer customer );

        void UpdateCustomer(Customer customer);

        Customer GetById(int Id);

    }
}
