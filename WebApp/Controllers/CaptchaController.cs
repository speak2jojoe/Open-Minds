using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using CaptchaMvc.HtmlHelpers;

namespace WebApp.Controllers
{
   
     public class CaptchaController : Controller
        {
            // GET: Captcha  
            public ActionResult Index()
            {
                return View();
            }

            [HttpPost]
            public ActionResult ValidateCaptcha()
            {
                // Code for validating the Captcha  
                if (this.IsCaptchaValid("Validate your captcha"))
                {
                    ViewBag.ErrMessage = "Valid";
                }
                else
                {
                    ViewBag.ErrMessage = "Invalid";
                }
                return View("Index");
            }
        }
}