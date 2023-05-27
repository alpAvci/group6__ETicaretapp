using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities.Concrete;
using ETicaretApp.BLL.Abstract;
using ETicaretApp.DAL.Abstarct;

namespace ETicaretApp.BLL.Concrete
{
    public class Customermanager : ICustomerService
    {
        ICustomerDal _customerDal;

        public Customermanager (ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void CustomerAdd(Customer customer)
        {
            _customerDal.insert(customer);
        }

        public void CustomerDelete(Customer customer)
        {
            _customerDal.delete(customer);
        }

        public void CustomerUpdate(Customer customer)
        {
            _customerDal.update(customer);
        }

        public Customer GetById(int id)
        {
            return _customerDal.GetByID(id);
        }

        public List<Customer> GetList()
        {
            return _customerDal.getListAll();
        }
    }
}
