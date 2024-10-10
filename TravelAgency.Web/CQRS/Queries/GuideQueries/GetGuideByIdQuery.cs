using MediatR;
using TravelAgency.Web.CQRS.Results.GuideResult;

namespace TravelAgency.Web.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery: IRequest<GetGuideByIdQueryResult>
    {
        public GetGuideByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; } 
    }
}
