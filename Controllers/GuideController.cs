using Microsoft.AspNetCore.Mvc;

namespace TourismMVC.Controllers
{
    public class GuideController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
