namespace TravelAgency.Web.CQRS.Commands.DestinationCommands
{
    public class CreateDestinationCommand
    {
        public string City { get; set; }
        public string DayNight { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }
    }
}
