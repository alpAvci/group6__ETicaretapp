using ETicaretApp.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Abstract
{
    public interface IWorkTaskService
    {
        void WorkTaskAdd(WorkTask workTask);

        void WorkTaskDelete(WorkTask workTask);

        void WorkTaskUpdate(WorkTask workTask);

        List<WorkTask> GetList();

        WorkTask GetById(int id);
    }
}
