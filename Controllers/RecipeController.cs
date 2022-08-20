using Microsoft.AspNetCore.Mvc;

namespace FoodBlog.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
