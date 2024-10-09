using TravelAgency.Web.CQRS.Queries.DestinationQueries;
using TravelAgency.Web.CQRS.Results.DestinationResult;
using EntityLayer.Concrete;
using DataAccessLayer.Concrete;
namespace TravelAgency.Web.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.Id);
            return new GetDestinationByIdQueryResult
            {
                DestinationId = values.DestinationId,
                DestinationCity = values.DestinationCity,
                DestinationDayNight = values.DestionationDaysNight,
                DestinationPrice = values.DestionationPrice
            };
        }
    }
}
