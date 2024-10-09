using DataAccessLayer.Concrete;
using TravelAgency.Web.CQRS.Commands.DestinationCommands;
namespace TravelAgency.Web.CQRS.Handlers.DestinationHandlers
{
    public class RemoveDestinationCommandHandler
    {
        private readonly Context _context;

        public RemoveDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.DestinationId);
            _context.Destinations.Remove(values);
            _context.SaveChanges();
        }
    }
}
