using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities;

namespace ETicaretApp.DAL.Abstarct
{
    public interface IDepartmentDal
    {
        List<Department> ListAllDepartment();
        void AddDepartment(Department department);

        void DeleteDepartment(Department department);

        void UpdateDepartment(Department department);

        Department GetById(int Id);
    }
}
