using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using iTextSharp.text;
using Document = iTextSharp.text.Document;
using PageSize = iTextSharp.text.PageSize;
using Paragraph = iTextSharp.text.Paragraph;

namespace TravelAgency.Web.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "PdfRaporları.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            Paragraph paragraph = new Paragraph("Rezervasyon Pdf Raporu");
            document.Add(paragraph);
            document.Close();
            return File("/PdfReports/PdfRaporları.pdf", "application/pdf", "PdfRaporları.pdf");
        }

        public IActionResult StaticCustomerPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "PdfRaporları1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Misafir Adı: ");
            pdfPTable.AddCell("Misafir Soyadı: ");
            pdfPTable.AddCell("Misafir TC: ");

            pdfPTable.AddCell("Eylül");
            pdfPTable.AddCell("Yücedağ");
            pdfPTable.AddCell("11111111111");

            pdfPTable.AddCell("Ahmet");
            pdfPTable.AddCell("Domurcuk");
            pdfPTable.AddCell("11111111110");

            pdfPTable.AddCell("Esmanur");
            pdfPTable.AddCell("Karataş");
            pdfPTable.AddCell("11111111112");

            document.Add(pdfPTable);

            document.Close();
            return File("/PdfReports/PdfRaporları1.pdf", "application/pdf", "PdfRaporları1.pdf");
        }
    }
}
