using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ETicaretApp.DAL.Abstarct
{
    public interface ICommentDal
    {
        List<Comment> ListAllComment();
        void AddComment(Comment comment);

        void DeleteComment(Comment comment);

        void UpdateComment(Comment comment);

        Comment GetById(int Id);
    }
}
