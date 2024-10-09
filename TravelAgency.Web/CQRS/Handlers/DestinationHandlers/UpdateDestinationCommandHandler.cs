using DataAccessLayer.Concrete;
using TravelAgency.Web.CQRS.Commands.DestinationCommands;

namespace TravelAgency.Web.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.DestinationId);
            values.DestinationCity = command.DestinationCity;
            values.DestionationDaysNight = command.DestinationDayNight;
            values.DestionationPrice = command.DestinationPrice;
            _context.SaveChanges();
        }
    }
}
