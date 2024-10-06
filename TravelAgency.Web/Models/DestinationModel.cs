using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace TravelAgency.Web.Models
{
    public class DestinationModel
    {
        public string DestinationCity { get; set; }
        public bool DestinationStatus { get; set; }
        public string DestionationPrice { get; set; }
        public string DestionationDaysNight { get; set; }

    }
}

