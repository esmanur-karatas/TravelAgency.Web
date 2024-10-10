using MediatR;
using TravelAgency.Web.CQRS.Results.GuideResult;

namespace TravelAgency.Web.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery : IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
