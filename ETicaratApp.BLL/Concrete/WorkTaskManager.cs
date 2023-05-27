using ETicaratApp.Entities;
using ETicaretApp.BLL.Abstract;
using ETicaretApp.DAL.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Concrete
{
    public class WorkTaskManager : IWorkTaskService
    {
        IWorkTaskDal _workTaskDal;
        public WorkTask GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WorkTask> GetList()
        {
            throw new NotImplementedException();
        }

        public void WorkTaskAdd(WorkTask workTask)
        {
            throw new NotImplementedException();
        }

        public void WorkTaskDelete(WorkTask workTask)
        {
            throw new NotImplementedException();
        }

        public void WorkTaskUpdate(WorkTask workTask)
        {
            throw new NotImplementedException();
        }
    }
}
