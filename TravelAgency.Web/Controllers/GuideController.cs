using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.Controllers
{
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }
        public IActionResult Index()
        {
            var value = _guideService.TGetAll();
            return View(value);
        }

        [HttpGet]
        public IActionResult GuideDetails(int id)
        {

            ViewBag.i = id;
            var values = _guideService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult GuideDetails(Hotels p)
        {
            return View();
        }

    }
}
