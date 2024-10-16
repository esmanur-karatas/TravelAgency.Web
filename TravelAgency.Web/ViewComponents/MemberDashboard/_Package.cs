using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.ViewComponents.MemberDashboard
{
    public class _Package : ViewComponent
    {
        private readonly IPackageService _packageService;

        public _Package(IPackageService packageService)
        {
            _packageService = packageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _packageService.TGetPackage();
            return View(values);
        }
    }
}
