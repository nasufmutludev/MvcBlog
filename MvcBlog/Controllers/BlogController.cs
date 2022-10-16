using Microsoft.AspNetCore.Mvc;

namespace MvcBlog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
