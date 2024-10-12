using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelsService _hotelsService;

        public HotelController(IHotelsService hotelService)
        {
            _hotelsService = hotelService;
        }
        public IActionResult Index()
        {
            var value = _hotelsService.TGetAll();
            return View(value);
        }

        [HttpGet]
        public IActionResult HotelDetails(int id)
        {

            ViewBag.i = id;
            var values = _hotelsService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult HotelDetails(Hotels p)
        {
            return View();
        }

    }
}
