using ETicaratApp.Entities;
using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaratApp.DAL.Repostories
{
    public class ProductRepostory : IProductDal
    {
        Context pr = new Context();
        public void AddProduct(Product product)
        {
            pr.Add(product);
            pr.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            pr.Remove(product);
            pr.SaveChanges();
        }

        public Product GetById(int Id)
        {
            return pr.Products.Find(Id);
        }

        public List<Product> ListAllProduct()
        {
            return pr.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
            pr.Update(product);
            pr.SaveChanges();
        }
    }
}
