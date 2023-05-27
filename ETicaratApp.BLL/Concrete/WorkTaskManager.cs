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

        public WorkTaskManager(IWorkTaskDal workTaskDal)
        {
            _workTaskDal = workTaskDal;
        }

        public WorkTask GetById(int id)
        {
           return _workTaskDal.GetByID(id);
        }

        public List<WorkTask> GetList()
        {
           return _workTaskDal.getListAll();
        }

        public void WorkTaskAdd(WorkTask workTask)
        {
            _workTaskDal.insert(workTask);
        }

        public void WorkTaskDelete(WorkTask workTask)
        {
            _workTaskDal.delete(workTask);
        }

        public void WorkTaskUpdate(WorkTask workTask)
        {
            _workTaskDal.update(workTask);
        }
    }
}
