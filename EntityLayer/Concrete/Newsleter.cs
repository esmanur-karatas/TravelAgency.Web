
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Newsleter
    {
        [Key]
        public int NewsleterId { get; set; }
        public string NewsleterMail { get; set; }
    }
}
