using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
