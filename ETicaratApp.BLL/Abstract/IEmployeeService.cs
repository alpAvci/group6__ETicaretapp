using ETicaratApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Abstract
{
    public interface IEmployeeService
    {
        void EmployeeAdd(Employee Employee);

        void EmployeeDelete(Employee Employee);

        void EmployeeUpdate(Employee Employee);

        List<Employee> GetList();

        Employee GetById(int id);
    }
}
