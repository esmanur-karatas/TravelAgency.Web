using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using TravelAgency.Web.CQRS.Results.DestinationResult;

namespace TravelAgency.Web.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                DestinationId = x.DestinationId,
                DestinationCity = x.DestinationCity,
                DestinationDayNight = x.DestionationDaysNight,
                DestinationPrice = x.DestionationPrice

            }).AsNoTracking().ToList();
            return values;
        }
    }
}
