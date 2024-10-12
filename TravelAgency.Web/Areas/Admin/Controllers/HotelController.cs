using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/Hotel")]
	public class HotelController : Controller
	{
		private readonly IHotelsService _hotelsService;

		public HotelController(IHotelsService hotelsService)
		{
			_hotelsService = hotelsService;
		}

		[Route("Index")]
		public IActionResult Index()
		{
			var values = _hotelsService.TGetAll();
			return View(values);
		}

		public IActionResult DeleteHotel(int id)
		{
			var values = _hotelsService.TGetById(id);
			_hotelsService.TDelete(values);
			return RedirectToAction("Index");
		}

		[Route("AddHotel")]
		[HttpGet]
		public IActionResult AddHotel()
		{
			return View();
		}

		[Route("AddHotel")]
		[HttpPost]
		public IActionResult AddHotel(Hotels hotels)
		{
			_hotelsService.TAdd(hotels);
			return RedirectToAction("Index");
		}

		[Route("UpdateHotel/{id}")]
		[HttpGet]
		public IActionResult UpdateHotel(int id)
		{
			var values = _hotelsService.TGetById(id);
			return View(values);
		}

		[Route("UpdateHotel/{id}")]
		[HttpPost]
		public IActionResult UpdateGuide(Hotels hotels)
		{
			_hotelsService.TUpdate(hotels);
			return RedirectToAction("Index");
		}
	}
}
