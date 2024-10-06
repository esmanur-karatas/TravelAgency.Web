namespace TravelAgency.Web.Areas.Member.Models
{
    public class GuideEditViewModel
    {
        public int GuideId { get; set; }
        public string GuideName { get; set; }
        public string GuideSurname { get; set; }
        public string GuideDescription { get; set; }
        public string InstagramUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile Image { get; set; }
        public bool Status { get; set; }
    }
}
