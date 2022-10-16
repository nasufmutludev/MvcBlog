using DataAccess.Concrete.EntityFramework;
using DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MvcBlog.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _categoryManager=new CategoryManager(new EfCategoryDal());

        public IActionResult Index()
        {
            var result = _categoryManager.ListAllCategory();
            return View(result);
        }
    }
}
