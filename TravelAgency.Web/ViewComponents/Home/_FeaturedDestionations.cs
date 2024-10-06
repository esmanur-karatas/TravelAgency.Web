using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.ViewComponents.Home
{
    public class _FeaturedDestionations : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var value = destinationManager.TGetAll();
            return View(value);
        }
    }
}
