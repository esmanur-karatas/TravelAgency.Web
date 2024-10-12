using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.Controllers
{
	public class DestinationController : Controller
	{
        private readonly IDestinationService _destinationService;
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(IDestinationService destinationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _userManager = userManager;
        }

        public IActionResult Index()
		{
			var value = _destinationService.TGetAll();
			return View(value);
		}

		[HttpGet]
		public async Task<IActionResult> DestinationDetails(int id)
		{

            ViewBag.i = id;
			ViewBag.destId = id;
			var value = await _userManager.FindByNameAsync(User.Identity.Name);
			ViewBag.UserId = value.Id;
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
