using Microsoft.AspNetCore.Mvc;

namespace TourismMVC.Controllers
{
    public class TouristController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
