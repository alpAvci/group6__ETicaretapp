using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities.Concrete;
using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Concrete;

namespace ETicaretApp.DAL.Repostories
{
    public class CommentRepostory : ICommentDal
    {
        Context cm = new Context();
        public void AddComment(Comment comment)
        {
            cm.Add(comment);
            cm.SaveChanges();
        }

        public void DeleteComment(Comment comment)
        {
            cm.Remove(comment);
            cm.SaveChanges();
        }

        public Comment GetById(int Id)
        {
            return cm.Comments.Find(Id);
        }

        public List<Comment> ListAllComment()
        {
            return cm.Comments.ToList();
        }

        public void UpdateComment(Comment comment)
        {
            cm.Update(comment);
            cm.SaveChanges();

        }
    }
}
