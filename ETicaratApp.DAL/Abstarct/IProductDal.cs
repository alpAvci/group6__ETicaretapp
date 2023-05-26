using ETicaratApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Abstarct
{
    public interface IProductDal
    {
        List<Product> ListAllProduct();
        void AddProduct(Product product);

        void DeleteProduct(Product product);

        void UpdateProduct(Product product);

        Product GetById(int Id);

    }
}
