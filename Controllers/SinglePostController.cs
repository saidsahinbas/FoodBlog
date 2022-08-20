using Microsoft.AspNetCore.Mvc;

namespace FoodBlog.Controllers
{
    public class SinglePostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
