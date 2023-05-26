using ETicaratApp.Entities;
using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.DAL.Repostories
{
    public class EmployeeRepostory : IEmployeeDal
    {
        Context em = new Context();
        public void AddEmployee(Employee employee)
        {
            em.Add(employee);
            em.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            em.Remove(employee);
            em.SaveChanges();
        }

        public Employee GetById(int Id)
        {
            return em.Employees.Find(Id);

        }

        public List<Employee> ListAllEmployee()
        {
            return em.Employees.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            em.Update(employee);
            em.SaveChanges();
        }
    }
}
