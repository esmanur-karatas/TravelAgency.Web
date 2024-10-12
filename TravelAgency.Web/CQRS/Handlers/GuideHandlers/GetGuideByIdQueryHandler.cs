using DataAccessLayer.Concrete;
using MediatR;
using NuGet.Protocol.Plugins;
using TravelAgency.Web.CQRS.Queries.GuideQueries;
using TravelAgency.Web.CQRS.Results.GuideResult;

namespace TravelAgency.Web.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuideId = values.GuideId,
                GuideName = values.GuideName,
                GuideSurname = values.GuideSurname,
                GuideDescription = values.GuideDescription,
                GuideDescription2 = values.GuideDescription2,
                ImageUrl = values.ImageUrl,

            };
        }
    }
}
