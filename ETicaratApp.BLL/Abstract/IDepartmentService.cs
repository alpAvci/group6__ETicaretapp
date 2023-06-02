using ETicaretApp.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Abstract
{
    public interface IDepartmentService
    {
        void DepmartmentAdd(Department Department);

        void DepmartmentDelete(Department Department);

        void DepmartmentUpdate(Department Department);

        List<Department> GetList();

        Department GetById(int id);
    }
}
