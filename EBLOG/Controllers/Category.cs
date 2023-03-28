using Microsoft.AspNetCore.Mvc;

namespace EBLOG.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
