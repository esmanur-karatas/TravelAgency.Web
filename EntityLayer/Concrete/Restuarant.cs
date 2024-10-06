
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Restuarant
    {
        [Key]
        public int RestuarantId { get; set; }
        public string RestuarantName { get; set; }
        public string RestuarantCity { get; set; }
        public string RestuarantImageUrl { get; set; }
        public string RestuarantDescription { get; set; }
        public bool RestuarantStatus { get; set; }
    }
}
