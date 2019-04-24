using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using LinqToExcel;
using System.Data.SqlClient;
using ClosedXML.Excel;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Helpers;


namespace TestApp.Controllers
{
    public class UserController : Controller
    {
        private TestingEntities db = new TestingEntities();

        // GET: User  
        public ActionResult Index()
        {
            ViewBag.i = "IndexPage";
            return View();
        }

        public ActionResult MyChart()
        {
            int Lag = 20;
            int Abj = 30;
            int PH = 40;
            int Enu = 50;
            int Owe = 70;

            new System.Web.Helpers.Chart(width: 800, height: 200)
                .AddSeries(
                    chartType: "column",
                    xValue: new[] { "Lag", "Abj", "PH", "Enu", "Owe" },
                    yValues: new[] { Lag, Abj, PH, Enu, Owe }
                )
                .Write("png");
            return null;
        }

        public ActionResult MyChart1()
        {
            int Lag = 20;
            int Abj = 30;
            int PH = 40;
            int Enu = 50;
            int Owe = 70;

            string myTheme = @"<Chart BackColor=""Transparent"">
                                    <ChartAreas>
                                        <ChartArea Name=""Default"" BackColor=""Transparent""></ChartArea>
                                    </ChartAreas>
                               </Chart>";

            new System.Web.Helpers.Chart(width: 800, height: 200, theme: myTheme)
                .AddSeries(
                    chartType: "Pie",
                    xValue: new[] { "Lag", "Abj", "PH", "Enu", "Owe" },
                    yValues: new[] { Lag, Abj, PH, Enu, Owe }
                )
                .Write("png");
            return null;
        }

        public ActionResult MyChart2()
        {
            int Lag = 20;
            int Abj = 30;
            int PH = 40;
            int Enu = 50;
            int Owe = 70;

            string myTheme = @"<Chart BackColor=""Transparent"">
                                    <ChartAreas>
                                        <ChartArea Name=""Default"" BackColor=""Transparent""></ChartArea>
                                    </ChartAreas>
                               </Chart>";

            new System.Web.Helpers.Chart(width: 800, height: 200, theme: myTheme)
                .AddSeries(
                    chartType: "Line",
                    xValue: new[] { "Lag", "Abj", "PH", "Enu", "Owe" },
                    yValues: new[] { Lag, Abj, PH, Enu, Owe }
                )
                .Write("png");
            return null;
        }

        public ActionResult MyChart3()
        {
            int Lag = 20;
            int Abj = 30;
            int PH = 40;
            int Enu = 50;
            int Owe = 70;

            string myTheme = @"<Chart BackColor=""Transparent"">
                                    <ChartAreas>
                                        <ChartArea Name=""Default"" BackColor=""Transparent""></ChartArea>
                                    </ChartAreas>
                               </Chart>";

            new System.Web.Helpers.Chart(width: 800, height: 200, theme: myTheme)
                .AddSeries(
                    chartType: "Bar",
                    xValue: new[] { "Lag", "Abj", "PH", "Enu", "Owe" },
                    yValues: new[] { Lag, Abj, PH, Enu, Owe }
                )
                .Write("png");
            return null;
        }

        public ActionResult MyChart4()
        {
            int Lag = 20;
            int Abj = 30;
            int PH = 40;
            int Enu = 50;
            int Owe = 70;

            string myTheme = @"<Chart BackColor=""Transparent"">
                                    <ChartAreas>
                                        <ChartArea Name=""Default"" BackColor=""Transparent""></ChartArea>
                                    </ChartAreas>
                               </Chart>";

            new System.Web.Helpers.Chart(width: 800, height: 200, theme: myTheme)
                .AddSeries(
                    chartType: "Radar",
                    xValue: new[] { "Lag", "Abj", "PH", "Enu", "Owe" },
                    yValues: new[] { Lag, Abj, PH, Enu, Owe }
                )
                .Write("png");
            return null;
        }

        public ActionResult MyChart5()
        {
            int Lag = 20;
            int Abj = 30;
            int PH = 40;
            int Enu = 50;
            int Owe = 70;

            string myTheme = @"<Chart BackColor=""Transparent"">
                                    <ChartAreas>
                                        <ChartArea Name=""Default"" BackColor=""Transparent""></ChartArea>
                                    </ChartAreas>
                               </Chart>";

            new System.Web.Helpers.Chart(width: 800, height: 200, theme: myTheme)
                .AddSeries(
                    chartType: "Polar",
                    xValue: new[] { "Lag", "Abj", "PH", "Enu", "Owe" },
                    yValues: new[] { Lag, Abj, PH, Enu, Owe }
                )
                .Write("png");
            return null;
        }

        public ActionResult MyChart6()
        {
            int Lag = 20;
            int Abj = 30;
            int PH = 40;
            int Enu = 50;
            int Owe = 70;

            string myTheme = @"<Chart BackColor=""Transparent"">
                                    <ChartAreas>
                                        <ChartArea Name=""Default"" BackColor=""Transparent""></ChartArea>
                                    </ChartAreas>
                               </Chart>";

            new System.Web.Helpers.Chart(width: 800, height: 200, theme: myTheme)
                .AddSeries(
                    chartType: "Doughnut",
                    xValue: new[] { "Lag", "Abj", "PH", "Enu", "Owe" },
                    yValues: new[] { Lag, Abj, PH, Enu, Owe }
                )
                .Write("png");
            return null;
        }

        public ActionResult MyChart7()
        {
            int Lag = 20;
            int Abj = 30;
            int PH = 40;
            int Enu = 50;
            int Owe = 70;

            string myTheme = @"<Chart BackColor=""Transparent"">
                                    <ChartAreas>
                                        <ChartArea Name=""Default"" BackColor=""Transparent""></ChartArea>
                                    </ChartAreas>
                               </Chart>";

            new System.Web.Helpers.Chart(width: 800, height: 200, theme: myTheme)
                .AddSeries(
                    chartType: "Bubble",
                    xValue: new[] { "Lag", "Abj", "PH", "Enu", "Owe" },
                    yValues: new[] { Lag, Abj, PH, Enu, Owe }
                )
                .Write("png");
            return null;
        }
        /// <summary>  
        /// This function is used to download excel format.  
        /// </summary>  
        /// <param name="Path"></param>  
        /// <returns>file</returns>  
        public FileResult DownloadExcel()
        {
            string path = "/Doc/Template/Template.xlsx";
            return File(path, "application/vnd.ms-excel", "Template.xlsx");
        }

        [HttpPost]
        public ActionResult UploadExcel(User users, HttpPostedFileBase FileUpload)
        {

            List<string> data = new List<string>();
            if (FileUpload != null)
            {
                // tdata.ExecuteCommand("truncate table OtherCompanyAssets");  
                if (FileUpload.ContentType == "application/vnd.ms-excel" || FileUpload.ContentType == "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
                {
                    string filename = FileUpload.FileName;
                    string targetpath = Server.MapPath("~/Doc/");
                    FileUpload.SaveAs(targetpath + filename);
                    string pathToExcelFile = targetpath + filename;
                    var connectionString = "";
                    if (filename.EndsWith(".xls"))
                    {
                        connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", pathToExcelFile);
                    }
                    else if (filename.EndsWith(".xlsx"))
                    {
                        connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";", pathToExcelFile);
                    }

                    var adapter = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", connectionString);
                    var ds = new DataSet();

                    adapter.Fill(ds, "ExcelTable");

                    DataTable dtable = ds.Tables["ExcelTable"];

                    string sheetName = "Sheet1";

                    var excelFile = new ExcelQueryFactory(pathToExcelFile);
                    var artistAlbums = from a in excelFile.Worksheet<User>(sheetName) select a;

                    int FailCounter = 0;
                    int PassCounter = 0;
                    ViewBag.i = "notIndexPage";

                    foreach (var a in artistAlbums)
                    {
                        String Usercheck = "pass";
                        if (a.name == "" || a.phoneno == "" || a.email == "")
                        {
                            Usercheck = "fail";
                        }
                        var model = (from u in db.Users where u.email.ToString() == a.email.ToString() select u).ToList();
                        if (model.Count() > 0)
                        {
                            Usercheck = "fail";
                        }
                        if (Usercheck == "pass")
                        {
                            try
                            {

                                User TU = new User();
                                TU.name = a.name;
                                TU.phoneno = a.phoneno;
                                TU.email = a.email;
                                TU.address = a.address;
                                TU.status = a.status;
                                db.Users.Add(TU);

                                db.SaveChanges();

                                PassCounter = PassCounter + 1;
                            }
                            catch (DbEntityValidationException ex)
                            {
                                FailCounter = FailCounter + 1;

                            }
                            /*
                            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                            {
                                //FailCounter = FailCounter + 1;
                                Exception raise = dbEx;
                                foreach (var validationErrors in dbEx.EntityValidationErrors)
                                {
                                    foreach (var validationError in validationErrors.ValidationErrors)
                                    {
                                        string message = string.Format("{0}:{1}",
                                            validationErrors.Entry.Entity.ToString(),
                                            validationError.ErrorMessage);
                                        // raise a new exception nesting  
                                        // the current instance as InnerException  
                                        raise = new InvalidOperationException(message, raise);
                                    }
                                }
                                throw raise;
                            }

                            catch (DbEntityValidationException ex)
                            {
                                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                                {

                                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                                    {

                                        Response.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);

                                    }

                                }

                            }*/
                        }
                        else
                        {
                            FailCounter = FailCounter + 1;
                        }
                    }
                    //deleting excel file from folder  
                    if ((System.IO.File.Exists(pathToExcelFile)))
                    {
                        System.IO.File.Delete(pathToExcelFile);
                    }
                    //return Json("success", JsonRequestBehavior.AllowGet);
                    ViewBag.p = PassCounter;
                    ViewBag.f = FailCounter;
                    return View("Index");
                }
                else
                {
                    //alert message for invalid file format  
                    data.Add("<ul>");
                    data.Add("<li>Only Excel file format is allowed</li>");
                    data.Add("</ul>");
                    data.ToArray();
                    //return Json(data, JsonRequestBehavior.AllowGet);
                    ViewBag.Message = "formaterror";
                    return View("Index");
                }
            }
            else
            {
                data.Add("<ul>");
                if (FileUpload == null) data.Add("<li>Please choose Excel file</li>");
                data.Add("</ul>");
                data.ToArray();
                //return Json(data, JsonRequestBehavior.AllowGet);
                ViewBag.Message = "empty";
                return View("Index");
            }
        }

        // from multiple tables 
        /*public IList<EmployeeViewModel> GetEmployeList()
        {
            var employeeList = (from e in db.Employees
                                join d in db.Departments on e.DepartmentId equals d.DepartmentId
                                select new EmployeeViewModel
                                {
                                    Name = e.Name,
                                    Email = e.Email,
                                    Age = (int)e.Age,
                                    Address = e.Address,
                                    Department = d.DepartmentName
                                }).ToList();
            return employeeList;
        }*/

        // for single table
        public IList<User> GetEmployeeList()
        {
            var tm = db.Users.OrderBy(a => a.id).ToList();

            return tm;
        }

        public ActionResult ExportToExcel()
        {
            var gv = new GridView();
            gv.DataSource = this.GetEmployeeList();
            gv.DataBind();
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=DemoExcel.xls");
            Response.ContentType = "application/ms-excel";
            Response.Charset = "";
            StringWriter objStringWriter = new StringWriter();
            HtmlTextWriter objHtmlTextWriter = new HtmlTextWriter(objStringWriter);
            gv.RenderControl(objHtmlTextWriter);
            Response.Output.Write(objStringWriter.ToString());
            Response.Flush();
            Response.End();
            return View("Index");
        }

    }
}