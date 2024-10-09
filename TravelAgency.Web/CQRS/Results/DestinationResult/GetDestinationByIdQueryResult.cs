namespace TravelAgency.Web.CQRS.Results.DestinationResult
{
    public class GetDestinationByIdQueryResult
    {
        public int DestinationId { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationDayNight { get; set; }
        public string DestinationPrice { get; set; }
    }
}
