using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities;
using ETicaratApp.Entities.Concrete;

namespace ETicaretApp.BLL.Abstract
{
    public interface IAdminService
    {
        void AdminAdd(Admin admin);

        void AdminDelete(Admin Admin);

        void AdminUpdate(Admin Admin);

        List<Admin> GetList();

        Admin GetById(int id);
    }
}
