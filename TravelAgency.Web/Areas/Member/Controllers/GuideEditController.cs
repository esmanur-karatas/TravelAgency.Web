using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using TravelAgency.Web.Areas.Member.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Elfie.Serialization;

namespace TravelAgency.Web.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class GuideEditController : Controller
    {
        private readonly IGenericService<Guide> _guideService;

        public GuideEditController(IGenericService<Guide> guideService)
        {
            _guideService = guideService;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Rehber ekleme işlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(GuideEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var guide = new Guide
                {
                    GuideName = model.GuideName,
                    GuideSurname = model.GuideSurname,
                    GuideDescription = model.GuideDescription,
                    InstagramUrl = model.InstagramUrl,
                    TwitterUrl = model.TwitterUrl,
                    Status = model.Status
                };

                if (model.Image != null)
                {
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/GuideImage", model.Image.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.Image.CopyToAsync(stream);
                    }
                    guide.ImageUrl = $"/images/{model.Image.FileName}";
                }

                _guideService.TAdd(guide);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        // Rehber düzenleme formu
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var guide = _guideService.TGetById(id);
            if (guide == null)
            {
                return NotFound();
            }

            var model = new GuideEditViewModel
            {
                GuideName = guide.GuideName,
                GuideSurname = guide.GuideSurname,
                GuideDescription = guide.GuideDescription,
                InstagramUrl = guide.InstagramUrl,
                TwitterUrl = guide.TwitterUrl,
                ImageUrl = guide.ImageUrl,
                Status = guide.Status,
                GuideId = guide.GuideId
            };

            return View(model);
        }

        // Rehber güncelleme işlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(GuideEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var guide = _guideService.TGetById(model.GuideId);
                if (guide == null)
                {
                    return NotFound();
                }

                guide.GuideName = model.GuideName;
                guide.GuideSurname = model.GuideSurname;
                guide.GuideDescription = model.GuideDescription;
                guide.InstagramUrl = model.InstagramUrl;
                guide.TwitterUrl = model.TwitterUrl;
                guide.Status = model.Status;

                if (model.Image != null)
                {
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", model.Image.FileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.Image.CopyToAsync(stream);
                    }
                    guide.ImageUrl = $"/images/{model.Image.FileName}";
                }

                _guideService.TUpdate(guide);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        // Rehber silme işlemi
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var guide = _guideService.TGetById(id);
            if (guide == null)
            {
                return NotFound();
            }

            _guideService.TDelete(guide);
            return RedirectToAction("Index", "Home");
        }
    }
}
