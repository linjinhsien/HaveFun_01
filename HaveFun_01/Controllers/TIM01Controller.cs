using Microsoft.AspNetCore.Mvc;

namespace HaveFun_01.Controllers
{
    public class TIM01Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
