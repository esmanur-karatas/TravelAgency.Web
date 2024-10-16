using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RestuarantController : Controller
    {
        RestuarantManager restuarantManager = new RestuarantManager(new
           EfRestuarantDal());
        public IActionResult Index()
        {
            var values = restuarantManager.TGetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRestuarant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRestuarant(Restuarant restuarant)
        {
            restuarantManager.TAdd(restuarant);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteRestuarant(int id)
        {
            var values = restuarantManager.TGetById(id);
            restuarantManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateRestuarant(int id)
        {
            var values = restuarantManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateRestuarant(Restuarant restuarant)
        {
            restuarantManager.TUpdate(restuarant);
            return RedirectToAction("Index");
        }
    }
}
