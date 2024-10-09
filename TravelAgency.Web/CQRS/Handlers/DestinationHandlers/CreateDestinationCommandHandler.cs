using DataAccessLayer.Concrete;
using TravelAgency.Web.CQRS.Commands.DestinationCommands;

namespace TravelAgency.Web.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle (CreateDestinationCommand command)
        {
            _context.Destinations.Add(new EntityLayer.Concrete.Destination
            {
                DestinationCity = command.City,
                DestionationPrice = command.Price,
                DestionationDaysNight = command.DayNight,
                DestinationStatus = true
            });
            _context.SaveChanges();
        }
    }
}
