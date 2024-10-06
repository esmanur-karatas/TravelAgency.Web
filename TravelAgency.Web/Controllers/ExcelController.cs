using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Office2010.Ink;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using TravelAgency.Web.Models;

namespace TravelAgency.Web.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    DestinationCity = x.DestinationCity,
                    DestionationDaysNight = x.DestionationDaysNight,
                    DestionationPrice = x.DestionationPrice,
                    DestinationStatus = x.DestinationStatus,

                }).ToList();
                return destinationModels;
            }
        }
        public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadssheetml.sheet", "Turlar.xlsx");

        }
        public IActionResult DestinationExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.DestinationCity;
                    workSheet.Cell(rowCount, 2).Value = item.DestionationDaysNight;
                    workSheet.Cell(rowCount, 3).Value = item.DestionationPrice;
                    workSheet.Cell(rowCount, 4).Value = item.DestinationStatus;
                    rowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadssheetml.sheet", "Tur Listesi.xlsx");
                }

            }
        }
    }
}

