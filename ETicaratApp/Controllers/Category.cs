using ETicaretApp.BLL.Concrete;
using ETicaretApp.DAL.Entity_Framework;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretApp.Panel.UI.Controllers
{
    public class Category : Controller
    {

        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {

            var values = cm.GetList();

            return View(values);
        }
    }
}
