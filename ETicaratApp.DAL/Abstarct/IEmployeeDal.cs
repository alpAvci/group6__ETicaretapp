using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities;

namespace ETicaretApp.DAL.Abstarct
{
    public interface IEmployeeDal
    {
        List<Employee> ListAllEmployee();
        void AddEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        void UpdateEmployee(Employee employee);

       Employee GetById(int Id);
    }
}
