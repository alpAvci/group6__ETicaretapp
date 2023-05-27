using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Repostories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class 
    {
         public void delete(T t)
        {
            Context c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            Context c = new Context();

            return c.Set<T>().Find(id);
        }

        public List<T> getListAll()
        {
            Context c = new Context();

            return c.Set<T>().ToList();
        }

        public void insert(T t)
        {
            Context c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void update(T t)
        {
            Context c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
