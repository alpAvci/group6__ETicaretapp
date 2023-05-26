using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities;
using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Concrete;

namespace ETicaretApp.DAL.Repostories
{
    public class DepartmentRepostory : IDepartmentDal
    {
        Context d = new Context();
        public void AddDepartment(Department department)
        {
            d.Add(department);
            d.SaveChanges();
        }

        public void DeleteDepartment(Department department)
        {
            d.Remove(department);
            d.SaveChanges();
        }

        public Department GetById(int Id)
        {
            return d.Departments.Find(Id);

        }

        public List<Department> ListAllDepartment()
        {
            return d.Departments.ToList();
        }

        public void UpdateDepartment(Department department)
        {
            d.Update(department);
            d.SaveChanges();
        }
    }
}
