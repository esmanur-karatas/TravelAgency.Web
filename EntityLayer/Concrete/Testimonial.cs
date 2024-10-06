
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int Id {  get; set; }
        public string Client { get; set; }
        public string Cooment { get; set; }
        public string City { get; set; }
        public string ClientImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
