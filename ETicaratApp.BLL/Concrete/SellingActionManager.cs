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
    public class SellingActionManager : ISellingActionService
    {
        ISellingActionDal _SellingActionDal;

        public SellingActionManager(ISellingActionDal sellingActionDal)
        {
            _SellingActionDal = sellingActionDal;
        }

        

        public SellingAction GetById(int id)
        {
            return _SellingActionDal.GetByID(id);
        }

        public List<SellingAction> GetList()
        {
            return _SellingActionDal.getListAll();
        }

        public void SellinActionAdd(SellingAction sellingAction)
        {
            _SellingActionDal.insert(sellingAction);
        }

        public void SellinActionDelete(SellingAction sellingAction)
        {
            _SellingActionDal.delete(sellingAction);
        }

        public void SellinActionUpdate(SellingAction sellingAction)
        {
            _SellingActionDal.update(sellingAction);
        }
    }
}
