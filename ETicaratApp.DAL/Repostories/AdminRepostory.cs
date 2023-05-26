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
    public class AdminRepostory : IAdminDal
    {
        Context a = new Context();
        public void AddAdmin(Admin admin)
        {
            a.Add(admin);
            a.SaveChanges();
        }

        public void DeleteAdmin(Admin admin)
        {
            a.Remove(admin);
            a.SaveChanges();
        }

        public Admin GetById(int Id)
        {
            return a.Admins.Find(Id);
        }

        public List<Admin> ListAllAdmin()
        {
            return a.Admins.ToList();
        }

        public void UpdateAdmin(Admin admin)
        {
            a.Update(admin);
            a.SaveChanges();
        }
    }
}
