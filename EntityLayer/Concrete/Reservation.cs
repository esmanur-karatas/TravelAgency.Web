using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int AppUserId { get; set; }

        [ForeignKey("AppUserId")]
        public AppUser AppUser { get; set; }
        public string PersonCount { get; set; }
        public DateTime ReservationDateTime { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int DestinationId { get; set; }
        [ForeignKey("DestinationId")]
        public Destination Destination { get; set; }

    }
}
