using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.ViewComponents.AdminDashboard
{
    public class _TotalRevenue :ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
