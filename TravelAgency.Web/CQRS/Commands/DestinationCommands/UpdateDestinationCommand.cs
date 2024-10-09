namespace TravelAgency.Web.CQRS.Commands.DestinationCommands
{
    public class UpdateDestinationCommand
    {
        public int DestinationId { get; set; }
        public string DestinationCity { get; set; }
        public string DestinationDayNight { get; set; }
        public string DestinationPrice { get; set; }
    }
}
