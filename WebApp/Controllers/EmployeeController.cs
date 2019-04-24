using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        //  
        // GET: /Employee/  

        private TestingEntities db = new TestingEntities();

        public ActionResult Index(string sortOrder, string CurrentSort, int? page)
        {
            int pageSize = 2;
            int pageIndex = 1;
            pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;

            ViewBag.CurrentSort = sortOrder;

            sortOrder = String.IsNullOrEmpty(sortOrder) ? "id" : sortOrder;

            IPagedList<User> emp = null;

            switch (sortOrder)
            {
                case "id":
                    if (sortOrder.Equals(CurrentSort))
                        emp = db.Users.OrderByDescending
                                (m => m.id).ToPagedList(pageIndex, pageSize);
                    else
                        emp = db.Users.OrderBy
                                (m => m.id).ToPagedList(pageIndex, pageSize);
                    break;
                case "name":
                    if (sortOrder.Equals(CurrentSort))
                        emp = db.Users.OrderByDescending
                                (m => m.name).ToPagedList(pageIndex, pageSize);
                    else
                        emp = db.Users.OrderBy
                                (m => m.name).ToPagedList(pageIndex, pageSize);
                    break;

                case "email":
                    if (sortOrder.Equals(CurrentSort))
                        emp = db.Users.OrderByDescending
                                (m => m.email).ToPagedList(pageIndex, pageSize);
                    else
                        emp = db.Users.OrderBy
                                (m => m.email).ToPagedList(pageIndex, pageSize);
                    break;

                case "phoneno":
                    if (sortOrder.Equals(CurrentSort))
                        emp = db.Users.OrderByDescending
                                (m => m.phoneno).ToPagedList(pageIndex, pageSize);
                    else
                        emp = db.Users.OrderBy
                                (m => m.phoneno).ToPagedList(pageIndex, pageSize);
                    break;

                case "address":
                    if (sortOrder.Equals(CurrentSort))
                        emp = db.Users.OrderByDescending
                                (m => m.address).ToPagedList(pageIndex, pageSize);
                    else
                        emp = db.Users.OrderBy
                                (m => m.address).ToPagedList(pageIndex, pageSize);
                    break;

                case "status":
                    if (sortOrder.Equals(CurrentSort))
                        emp = db.Users.OrderByDescending
                                (m => m.status).ToPagedList(pageIndex, pageSize);
                    else
                        emp = db.Users.OrderBy
                                (m => m.status).ToPagedList(pageIndex, pageSize);
                    break;

                case "Default":
                    emp = db.Users.OrderBy
                            (m => m.id).ToPagedList(pageIndex, pageSize);
                    break;
            }
            return View(emp);
        }
    }
}