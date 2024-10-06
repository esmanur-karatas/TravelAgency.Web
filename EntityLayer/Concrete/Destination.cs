
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationImage { get; set; }
        public bool DestinationStatus { get; set; }
        public string DestionationPrice { get; set; }
        public string DestionationDescription { get; set; }
        public string DestionationDaysNight { get; set; }
        public string DestionationStars { get; set; }
        public string DestinationDetails { get; set; }
        public string DestinationDetails2 { get; set; }
        public string DestinationImageTwo { get; set;}
        public string DestinationImageTwo2 { get; set;}
        public string DestinationTag { get; set;}
        public List <Comment> Comments { get; set; }
        public List <Reservation> Reservations { get; set; }


    }
}
