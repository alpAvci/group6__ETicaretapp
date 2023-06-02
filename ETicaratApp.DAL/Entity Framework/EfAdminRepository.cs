using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretApp.EntitiesLayer.Concrete;
using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Repostories;
using ETicaretApp.DAL.Concrete;
using ETicaretApp.DAL.Abstarct;

namespace ETicaretApp.DAL.Entity_Framework
{
    public class EfAdminRepository : GenericRepository<Admin>, IAdminDal
    {
    }
}
