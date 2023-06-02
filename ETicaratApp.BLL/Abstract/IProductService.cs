using ETicaretApp.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Abstract
{
    public interface IProductService
    {
        void  ProductAdd(Product  Product);

        void  ProductDelete(Product  Product);

        void ProductUpdate(Product  Product);

        List<Product> GetList();

        Product GetById(int id);
    }
}
