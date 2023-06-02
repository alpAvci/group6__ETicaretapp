using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretApp.EntitiesLayer.Concrete;
using ETicaretApp.BLL.Abstract;
using ETicaretApp.DAL.Abstarct;

namespace ETicaretApp.BLL.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public void AdminAdd(Admin admin)
        {
          _adminDal.insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
            _adminDal.delete(admin);
        }

        public void AdminUpdate(Admin admin)
        {
            _adminDal.update(admin);
        }

        public Admin GetById(int id)
        {
            return _adminDal.GetByID(id);
        }

        public List<Admin> GetList()
        {
            return _adminDal.getListAll();
        }
    }
}
