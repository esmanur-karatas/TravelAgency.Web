using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.Controllers
{
	public class DestinationController : Controller
	{
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
		{
			var value = _destinationService.TGetAll();
			return View(value);
		}

		[HttpGet]
		public IActionResult DestinationDetails(int id)
		{

            ViewBag.i = id;
            var values = _destinationService.TGetById(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult DestinationDetails(Destination p)
		{
			return View();
		}
	}
}
