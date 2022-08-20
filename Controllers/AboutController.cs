using Microsoft.AspNetCore.Mvc;

namespace FoodBlog.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
