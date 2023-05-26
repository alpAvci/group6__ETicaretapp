using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities.Concrete;
using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Concrete;

namespace ETicaratApp.DAL.Repostories
{
    public class CategoryRepostory : ICategoryDal
    {
        Context c = new Context();
        public void AddCategory(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
          c.Remove(category);
            c.SaveChanges();
        }

        public Category GetById(int Id)
        {
            return c.Categories.Find(Id);
        }

        public List<Category> ListAllCategory()
        {
           return c.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
