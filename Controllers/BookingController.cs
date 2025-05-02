using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TourismMVC.Models;
using TourismMVC.Data;
using System.Linq;

namespace TourismMVC.Controllers
{
    public class BookingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public BookingController(AppDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var bookings = _context.Bookings.ToList();
            return View(bookings);
        }

        [HttpPost]
        public async Task<IActionResult> Book(int tourId)
        {
            var user = await _userManager.GetUserAsync(User);

            var booking = new Booking
            {
                TourId = tourId,
                TouristUserId = user.Id,
                Status = "Pending"
            };

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
