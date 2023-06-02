using ETicaretApp.EntitiesLayer.Concrete;
using ETicaretApp.BLL.Abstract;
using ETicaretApp.DAL.Abstarct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Concrete
{
    public class ProducManager : IProductService
    {
        IProductDal _IProductDal;

        public ProducManager(IProductDal iProductDal)
        {
            _IProductDal = iProductDal;
        }

        public Product GetById(int id)
        {
            return _IProductDal.GetByID(id);
        }

        public List<Product> GetList()
        {
            return _IProductDal.getListAll();
        }

        public void ProductAdd(Product Product)
        {
            _IProductDal.insert(Product);
        }

        public void ProductDelete(Product Product)
        {
            _IProductDal.delete(Product);
        }

        public void ProductUpdate(Product Product)
        {
            _IProductDal.update(Product);
        }
    }
}
