using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.ViewComponents.Home
{
    public class _HotelsPartial : ViewComponent
    {
        HotelsManager hotelsManager = new HotelsManager(new EfHotelsDal());
        public IViewComponentResult Invoke()
        {
            var value = hotelsManager.TGetAll();
            return View(value);
        }
    }
}
