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
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;

        public DepartmentManager (IDepartmentDal departmentDal)
        {
            _departmentDal= departmentDal;
        }
        public void DepmartmentAdd(Department department)
        {
            _departmentDal.insert(department);
        }

        public void DepmartmentDelete(Department department)
        {
             _departmentDal.update(department);
        }

        public void DepmartmentUpdate(Department department)
        {
            _departmentDal.update(department);
        }

        public Department GetById(int id)
        {
            return _departmentDal.GetByID(id);
        }

        public List<Department> GetList()
        {
            return _departmentDal.getListAll();
        }
    }
}
