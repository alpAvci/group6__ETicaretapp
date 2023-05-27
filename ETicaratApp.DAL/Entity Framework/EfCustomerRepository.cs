using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities.Concrete;
using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Repostories;

namespace ETicaretApp.DAL.Entity_Framework
{
    public class EfCustomerRepository : GenericRepository<Customer> , ICustomerDal
    {
    }
}
