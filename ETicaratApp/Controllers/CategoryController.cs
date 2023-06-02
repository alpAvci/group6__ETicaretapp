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



       






    }
}
