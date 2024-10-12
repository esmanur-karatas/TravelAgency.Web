namespace TravelAgency.Web.Models
{
    public class HotelModel
    {
        public int HotelId { get; set; }
        public string HotelCity { get; set; }
        public string HotelImageUrl { get; set; }
        public string HotelDescription { get; set; }
        public string HotelDayNight { get; set; }
        public double HotelPrice { get; set; }
        public bool HotelStatus { get; set; }
        public int HotelCapacity { get; set; }
    }
}
