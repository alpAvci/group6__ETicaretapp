using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaratApp.Entities;

namespace ETicaretApp.DAL.Abstarct
{
    public interface ISellingActionDal
    {
        List<SellingAction> ListAllSellingAction();
        void AddSellingAction(SellingAction sellingAction);

        void DeleteSellingAction(SellingAction sellingAction);

        void UpdateSellingAction(SellingAction sellingAction);

        SellingAction GetById(int Id);
    }
}
