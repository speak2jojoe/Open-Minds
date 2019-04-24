using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class HangfireController : Controller
    {
        private readonly HangFireService hfService = new HangFireService();
        // GET: Hangfire
        public ActionResult BackgroundEnqueue(string url)
        {
            try
            {
                hfService.Enqueue(url);
                ViewBag.response = "Job enqueued successfully.";
            }
            catch
            {
                ViewBag.response = "Sorry, an error occured";
            }
            return View();
        }


        public ActionResult BackgroundSchedule(string url, DateTime? scheduleDate)
        {
            try
            {                
                string res = hfService.Schedule(url, scheduleDate);
                ViewBag.response = res;
            }
            catch
            {
                ViewBag.response = "Sorry, an error occured";
            }
            return View("BackgroundEnqueue");
        }


        public ActionResult RecurringJob(string url, string cronExpression, string jobName)
        {
            try
            {
                string res = hfService.scheduleRecurring(url, cronExpression, jobName);
                ViewBag.response = res;
            }
            catch(Exception ex)
            {
                ViewBag.response = "Sorry, an error occured";
            }
            return View("BackgroundEnqueue");
        }
    }
}