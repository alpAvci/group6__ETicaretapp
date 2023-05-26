using ETicaratApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Abstarct
{
    public interface IAdminDal
    {

        List<Admin> ListAllAdmin();
        void AddAdmin(Admin admin);

        void DeleteAdmin(Admin admin);

        void UpdateAdmin(Admin admin);

        
        Admin GetById(int Id);

    }
}
