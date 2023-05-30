using ETicaretApp.BLL.Concrete;
using ETicaretApp.DAL.Entity_Framework;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretApp.Panel.UI.Controllers
{
    public class CategoryController : Controller
    {

       
        public IActionResult Index()
        {

            

            return View();
        }
    }
}
