using MediatR;

namespace TravelAgency.Web.CQRS.Commands.GuideCommands
{
    public class CreateGuideCommand: IRequest
    {
        public string GuideName { get; set; }
        public string GuideSurname { get; set; }
        public string GuideDescription { get; set; }
        public string ImageUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public Boolean Status { get; set; }
    }
}
