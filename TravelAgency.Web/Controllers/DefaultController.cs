using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
