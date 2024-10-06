using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.ViewComponents.Home
{
    public class _Statistic : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = "123";
            ViewBag.v3 = c.Hotels.Count();
            ViewBag.v4 = c.Resturants.Count();
            ViewBag.v5 = c.Destinations.Count();
            return View();
        }
    }
}
