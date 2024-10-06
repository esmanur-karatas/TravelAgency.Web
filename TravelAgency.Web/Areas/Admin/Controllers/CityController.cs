using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Drawing.Charts;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TravelAgency.Web.Models;

namespace TravelAgency.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetAll());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.DestinationStatus = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }

        public IActionResult GetById(int DestinationId)
        {
            var values = _destinationService.TGetById(DestinationId);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.TDelete(values);
            return NoContent();
        }

         public IActionResult UpdateCity (Destination destination)
        {
             _destinationService.TUpdate(destination);
            var v = JsonConvert.SerializeObject(destination);
            return Json(v);
        }

        #region Statik Liste
        public static List<CityModel> cities = new List<CityModel>()
        {
            new CityModel
            {
                CityId = 1,
                CityName = "Üsküp",
                CityCountry = "Makedonya"
            },
             new CityModel
            {
                CityId = 2,
                CityName = "Londra",
                CityCountry = "İngiltere"
            },
              new CityModel
            {
                CityId = 3,
                CityName = "Ankara",
                CityCountry = "Türkiye"
            },
               new CityModel
            {
                CityId = 4,
                CityName = "New York",
                CityCountry = "Amerika"
            }
        };
        #endregion
    }
}
