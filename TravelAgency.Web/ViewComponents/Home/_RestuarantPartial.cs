using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.ViewComponents.Home
{
    public class _RestuarantPartial : ViewComponent
    {
        RestuarantManager restuarantManager = new RestuarantManager(new EfRestuarantDal());
        public IViewComponentResult Invoke()
        {
            var value = restuarantManager.TGetAll();
            return View(value);
        }
    }
}
