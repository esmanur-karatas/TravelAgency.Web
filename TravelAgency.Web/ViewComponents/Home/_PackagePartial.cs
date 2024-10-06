using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.ViewComponents.Home
{
    public class _PackagePartial : ViewComponent
    {
        PackageManager packageManager = new PackageManager(new EfPackageDal());
        public IViewComponentResult Invoke()
        {
            var value = packageManager.TGetAll();
            return View(value);
        }
    }
}
