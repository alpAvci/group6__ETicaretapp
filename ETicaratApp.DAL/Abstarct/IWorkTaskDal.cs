using ETicaratApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Abstarct
{
    public interface IWorkTaskDal
    {
        List<WorkTask> ListAllWorkTask();
        void AddWorkTask(WorkTask worktask);

        void DeleteWorkTask(WorkTask worktask);

        void UpdateWorkTask(WorkTask worktask);

        WorkTask GetById(int Id);

    }
}
