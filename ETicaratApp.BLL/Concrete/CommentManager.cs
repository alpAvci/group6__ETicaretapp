using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretApp.EntitiesLayer.Concrete;
using ETicaretApp.BLL.Abstract;
using ETicaretApp.DAL.Abstarct;

namespace ETicaretApp.BLL.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal= commentDal;
        }
        public void CommentAdd(Comment comment)
        {
            _commentDal.insert(comment);
        }

        public void CommentDelete(Comment comment)
        {
            _commentDal.delete(comment);
        }

        public void CommentUpdate(Comment comment)
        {
            _commentDal.update(comment);
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetByID(id);
        }

        public List<Comment> GetList()
        {
            return _commentDal.getListAll();
        }
    }
}
