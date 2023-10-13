using Microsoft.AspNetCore.Mvc;

namespace PTUDW_02_KTPM.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
