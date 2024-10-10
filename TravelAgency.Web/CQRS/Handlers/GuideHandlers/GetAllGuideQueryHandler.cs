using DataAccessLayer.Concrete;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TravelAgency.Web.CQRS.Queries.GuideQueries;
using TravelAgency.Web.CQRS.Results.GuideResult;

namespace TravelAgency.Web.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery, List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;

        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuideId = x.GuideId,
                GuideName = x.GuideName,
                GuideSurname = x.GuideSurname,
                GuideDescription = x.GuideDescription,
                ImageUrl = x.ImageUrl
            }).AsNoTracking().ToListAsync();
        }
    }
}



