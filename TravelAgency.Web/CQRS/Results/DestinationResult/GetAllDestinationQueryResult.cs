namespace TravelAgency.Web.CQRS.Results.DestinationResult
{
    public class GetAllDestinationQueryResult
    {
        public int DestinationId { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationPrice { get; set; }
        public string DestinationDayNight { get; set; }
    }
}
