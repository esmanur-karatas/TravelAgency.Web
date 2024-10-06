using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
