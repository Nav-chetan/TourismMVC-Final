using Microsoft.AspNetCore.Mvc;

namespace TourismMVC.Controllers
{
    public class AgencyController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
