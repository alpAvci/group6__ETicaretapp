using ETicaretApp.EntitiesLayer.Concrete;
using ETicaretApp.BLL.Abstract;
using ETicaretApp.DAL.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _EmployeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _EmployeeDal = employeeDal;
        }

        public void EmployeeAdd(Employee Employee)
        {
            _EmployeeDal.insert(Employee);
        }

        public void EmployeeDelete(Employee Employee)
        {
            _EmployeeDal.delete(Employee);
        }

        public void EmployeeUpdate(Employee Employee)
        {
            _EmployeeDal.update(Employee);
        }

        public Employee GetById(int id)
        {
            return _EmployeeDal.GetByID(id);
        }

        public List<Employee> GetList()
        {
            return _EmployeeDal.getListAll();
        }
    }
}
