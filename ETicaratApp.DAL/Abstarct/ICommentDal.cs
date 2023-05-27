using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ETicaretApp.DAL.Abstarct
{
    public interface ICommentDal: IGenericDal<Comment>
    {
  
    }
}
