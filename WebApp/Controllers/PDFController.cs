using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

namespace WebApp.Controllers
{
    public class PDFController : Controller
    {
        public ActionResult Index()
        {
            TestingEntities entities = new TestingEntities();
            return View(from customer in entities.Charts.Take(3)
                        select customer);
        }

        [HttpPost]
        [ValidateInput(false)]
        public FileResult Export(string GridHtml)
        {
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(GridHtml);
                // step 1: creation of a document-object
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);                
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Grid.pdf");
            }
        }
    }
}
