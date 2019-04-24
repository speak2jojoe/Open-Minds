using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Collections;

namespace WebApp.Controllers
{
    public class ChartController : Controller
    {
        // GET: Charts
        private TestingEntities db = new TestingEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyChart()
        {
            ArrayList xV = new ArrayList ();
            ArrayList yV = new ArrayList();

            var result = db.Charts.OrderBy(b => b.id);
            result.ToList().ForEach(res => xV.Add(res.state));
            result.ToList().ForEach(res => yV.Add(res.allocation));

            new System.Web.Helpers.Chart(width: 800, height: 400, theme: ChartTheme.Green)
                .AddTitle("Allocation Chart [Column Chart]")
                .AddSeries(
                    "Default",
                    chartType: "column",
                    xValue:  xV, // { "Lag", "Abj", "PH", "Enu", "Owe" },
                    yValues: yV // new[] { Lag, Abj, PH, Enu, Owe }
                )
                .Write("bmp");
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

            new System.Web.Helpers.Chart(width: 800, height: 400, theme: myTheme)
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

            new System.Web.Helpers.Chart(width: 800, height: 400, theme: myTheme)
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

            new System.Web.Helpers.Chart(width: 800, height: 400, theme: myTheme)
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

            new System.Web.Helpers.Chart(width: 800, height: 400, theme: myTheme)
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

            new System.Web.Helpers.Chart(width: 800, height: 400, theme: myTheme)
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

            new System.Web.Helpers.Chart(width: 800, height: 400, theme: myTheme)
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

            new System.Web.Helpers.Chart(width: 800, height: 400, theme: myTheme)
                .AddSeries(
                    chartType: "Bubble",
                    xValue: new[] { "Lag", "Abj", "PH", "Enu", "Owe" },
                    yValues: new[] { Lag, Abj, PH, Enu, Owe }
                )
                .Write("png");
            return null;
        }

        public ActionResult MyChart8()
        {
            ArrayList xV = new ArrayList();
            ArrayList yV = new ArrayList();

            var result = db.Charts.OrderBy(b => b.id);
            result.ToList().ForEach(res => xV.Add(res.state));
            result.ToList().ForEach(res => yV.Add(res.allocation));

            new System.Web.Helpers.Chart(width: 800, height: 400, theme: ChartTheme.Green)
                .AddTitle("")
                .AddSeries(
                    "Default",
                    chartType: "stackedbar100",
                    xValue: xV, // { "Lag", "Abj", "PH", "Enu", "Owe" },
                    yValues: yV // new[] { Lag, Abj, PH, Enu, Owe }
                )
                .Write("bmp");
            return null;
        }

        public ActionResult MyChart9()
        {
            ArrayList xV = new ArrayList();
            ArrayList yV = new ArrayList();

            var result = db.Charts.OrderBy(b => b.id);
            result.ToList().ForEach(res => xV.Add(res.state));
            result.ToList().ForEach(res => yV.Add(res.allocation));

            new System.Web.Helpers.Chart(width: 800, height: 400, theme: ChartTheme.Green)
                .AddTitle("")
                .AddSeries(
                    "Default",
                    chartType: "boxplot",
                    xValue: xV, // { "Lag", "Abj", "PH", "Enu", "Owe" },
                    yValues: yV // new[] { Lag, Abj, PH, Enu, Owe }
                )
                .Write("bmp");
            return null;
        }

        public ActionResult MyChart10()
        {
            ArrayList xV = new ArrayList();
            ArrayList yV = new ArrayList();

            var result = db.Charts.OrderBy(b => b.id);
            result.ToList().ForEach(res => xV.Add(res.state));
            result.ToList().ForEach(res => yV.Add(res.allocation));

            new System.Web.Helpers.Chart(width: 800, height: 400, theme: ChartTheme.Green)
                .AddTitle("")
                .AddSeries(
                    "Default",
                    chartType: "pyramid",
                    xValue: xV, // { "Lag", "Abj", "PH", "Enu", "Owe" },
                    yValues: yV // new[] { Lag, Abj, PH, Enu, Owe }
                )
                .Write("bmp");
            return null;
        }
    }
}