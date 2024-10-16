using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.Controllers
{
	public class RestuarantController : Controller
	{
        private readonly IRestuarantService _restuarantService;

        public RestuarantController(IRestuarantService restuarantController)
        {
            _restuarantService = restuarantController;
        }
        public IActionResult Index()
        {
            var value = _restuarantService.TGetAll();
            return View(value);
        }

        [HttpGet]
        public IActionResult RestuarantDetails(int id)
        {

            ViewBag.i = id;
            var values = _restuarantService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult RestuarantDetails(Hotels p)
        {
            return View();
        }
    }
}
