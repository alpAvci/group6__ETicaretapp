using ETicaratApp.Entities;
using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Repostories
{
    public class WorkTaskRepostory : IWorkTaskDal
    {
        Context w = new Context();
        public void AddWorkTask(WorkTask worktask)
        {
           w.Add(worktask);
            w.SaveChanges();
        }

        public void DeleteWorkTask(WorkTask worktask)
        {
           w.Remove(worktask);
            w.SaveChanges();
        }

        public WorkTask GetById(int Id)
        {
            return w.WorkTasks.Find(Id);
        }

        public List<WorkTask> ListAllWorkTask()
        {
            return w.WorkTasks.ToList();
        }

        public void UpdateWorkTask(WorkTask worktask)
        {
            w.Update(worktask);
            w.SaveChanges();
        }
    }
}
