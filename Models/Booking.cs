namespace TourismMVC.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string TouristUserId { get; set; }
        public int TourId { get; set; }
        public string Status { get; set; } // Pending, Confirmed
    }
}
