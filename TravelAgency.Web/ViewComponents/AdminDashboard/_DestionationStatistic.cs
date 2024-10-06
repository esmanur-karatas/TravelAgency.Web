using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TravelAgency.Web.ViewComponents.AdminDashboard
{
    public class _DestionationStatistic : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
