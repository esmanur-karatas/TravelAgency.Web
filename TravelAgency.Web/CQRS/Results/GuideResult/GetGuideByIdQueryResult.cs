namespace TravelAgency.Web.CQRS.Results.GuideResult
{
    public class GetGuideByIdQueryResult
    {
        public int GuideId { get; set; }
        public string GuideName { get; set; }
        public string GuideSurname { get; set; }
        public string GuideDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}
