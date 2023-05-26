using ETicaratApp.Entities;
using ETicaretApp.DAL.Abstarct;
using ETicaretApp.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Repostories
{
    public class SellingActionRepostory : ISellingActionDal
    {

        Context s = new Context();
        public void AddSellingAction(SellingAction sellingAction)
        {
            s.Add(sellingAction);
            s.SaveChanges();
        }

        public void DeleteSellingAction(SellingAction sellingAction)
        {
           s.Remove(sellingAction);
            s.SaveChanges();
        }

        public SellingAction GetById(int Id)
        {
            return s.SellingActions.Find(Id);
        }

        public List<SellingAction> ListAllSellingAction()
        {
           return s.SellingActions.ToList();
        }

        public void UpdateSellingAction(SellingAction sellingAction)
        {
            s.Update(sellingAction);
            s.SaveChanges();
        }
    }
}
