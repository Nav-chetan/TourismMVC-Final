namespace TourismMVC.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; } // Agency/Guide Username
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
