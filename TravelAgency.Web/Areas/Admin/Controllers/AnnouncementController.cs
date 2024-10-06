﻿using AutoMapper;
using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Bibliography;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelAgency.Web.Areas.Admin.Models;

namespace TravelAgency.Web.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;
        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDTO>>(_announcementService.TGetAll());
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTOs model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement()
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())

                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.TGetById(id);
            _announcementService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnoucementUpdateDto>(_announcementService.TGetById(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnoucementUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementId = model.AnnouncementId,
                    Title = model.Title,
                    Content = model.Content,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
