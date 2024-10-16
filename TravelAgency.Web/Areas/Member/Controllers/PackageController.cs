using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.Areas.Member.Controllers
{
    [Area("Member")]
    public class PackageController : Controller
    {
        private readonly IPackageService _packageService;
        public PackageController(IPackageService packageService)
        {
            _packageService = packageService;
        }
        public IActionResult Index()
        {
            var values = _packageService.TGetPackage();
            return View(values);
        }
    }
}
