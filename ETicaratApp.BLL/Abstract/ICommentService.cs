using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities;
using ETicaratApp.Entities.Concrete;

namespace ETicaretApp.BLL.Abstract
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);

        void CommentDelete(Comment comment);

        void CommentUpdate(Comment comment);

        List<Comment> GetList();

        Comment GetById(int id);
    }
}
