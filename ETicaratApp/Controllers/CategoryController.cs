using ETicaretApp.BLL.Concrete;
using ETicaretApp.DAL.Concrete;
using ETicaretApp.DAL.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
using ETicaretApp.DAL.Concrete;
using ETicaretApp.EntitiesLayer.Concrete;

namespace ETicaretApp.Panel.UI.Controllers
{
    public class CategoryController : Controller
    {

        Context c = new Context();
        public IActionResult Index()
        {
           

            
            var degerler = c.Categories.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category k)
        {
            c.Categories.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult CategoryRemove(int id)
        {
            var cate = c.Categories.Find(id);
            c.Categories.Remove(cate);
            c.SaveChanges();
            return RedirectToAction("Index");

        }


        public IActionResult CategoryFetch(int id)
        {
            var category = c.Categories.Find(id);
            return View("CategoryFetch",category);


        }


        public IActionResult CategoryUpdate(Category K)
        {
            var ctg = c.Categories.Find(K.CategoryId);
            ctg.CategoryName = K.CategoryName;

            c.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}
