using ETicaretApp.EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.BLL.Abstract
{
    public interface ISellingActionService
    {
        void SellinActionAdd(SellingAction sellingAction);

        void SellinActionDelete(SellingAction sellingAction);

        void SellinActionUpdate(SellingAction sellingAction);

        List<SellingAction> GetList();

        SellingAction GetById(int id);
    }
}
