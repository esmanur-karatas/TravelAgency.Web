
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class SubAbout
    {
        [Key]
        public int SubAboutId { get; set; }
        public string SubAboutTitle { get; set; }
        public string SubAboutDescription { get; set; }
    }
}
