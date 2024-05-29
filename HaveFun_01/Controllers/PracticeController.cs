using Microsoft.AspNetCore.Mvc;

namespace HaveFun_01.Controllers
{
    public class PracticeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
