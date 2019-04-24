using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO; 

namespace WebApp.Controllers
{

    public class UploadController : Controller
    {
        // GET: Upload  
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                    file.SaveAs(_path);
                }
                ViewBag.Message = "File Uploaded Successfully!!";
                return View("index");
            }
            catch
            {
                ViewBag.Message = "File upload failed!!";
                return View("index");
            }
        }

        // Download
        [HttpGet]
        public FileResult Download(string ImageName) 
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"c:\users\josh\documents\visual studio 2015\Projects\WebApp\WebApp\UploadedFiles\");
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, ImageName);
            //var FileVirtualPath = Path.Combine(Server.MapPath("~/UploadedFiles"), ImageName); //Server.MapPath("/UploadedFiles/" + ImageName); 
            //return File(FileVirtualPath, "application/force-download", Path.GetFileName(FileVirtualPath)); 
        }

        // For multiple files 
        [HttpPost]
        public ActionResult UploadFiles(HttpPostedFileBase[] files)
        {

            //Ensure model state is valid  
            if (ModelState.IsValid)
            {   //iterating through multiple file collection   
                foreach (HttpPostedFileBase file in files)
                {
                    //Checking file is available to save.  
                    if (file != null)
                    {
                        var InputFileName = Path.GetFileName(file.FileName);
                        var ServerSavePath = Path.Combine(Server.MapPath("~/UploadedFiles/") + InputFileName);
                        //Save file to server folder  
                        file.SaveAs(ServerSavePath);
                        //assigning file uploaded status to ViewBag for showing message to user.  
                        ViewBag.UploadStatus = files.Count().ToString() + " files uploaded successfully.";
                    }

                }
            }
            return View();
        }

    }
}