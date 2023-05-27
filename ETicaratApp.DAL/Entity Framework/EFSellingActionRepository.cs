using ETicaratApp.Entities;
using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Entity_Framework
{
    public class EFSellingActionRepository : GenericRepository<SellingAction>, ISellingActionDal
    {
    }
}
