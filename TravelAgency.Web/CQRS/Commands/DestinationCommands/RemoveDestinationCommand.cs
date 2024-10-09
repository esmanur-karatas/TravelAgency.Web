namespace TravelAgency.Web.CQRS.Commands.DestinationCommands
{
    public class RemoveDestinationCommand
    {
        public RemoveDestinationCommand(int id)
        {
            DestinationId = id;
        }

        public int DestinationId { get; set; }
    }
}
