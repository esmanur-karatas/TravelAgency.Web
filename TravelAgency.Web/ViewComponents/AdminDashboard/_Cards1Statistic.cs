using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic : ViewComponent
    {
        Context _context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _context.Destinations.Count();
            ViewBag.v2 = _context.Users.Count();
            return View();
        }
    }
}
