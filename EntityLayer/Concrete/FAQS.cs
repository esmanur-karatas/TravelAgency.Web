
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class FAQS
    {
        [Key]
        public int FaqsId { get; set; }
        public string FaqsTitle { get; set; }
        public string FaqsDescription { get; set; }
    }
}
