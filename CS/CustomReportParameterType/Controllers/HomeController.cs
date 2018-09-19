using System.Web.Mvc;
using CustomReportParameterType.Services;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.Native;
using DevExpress.XtraReports.UI;

namespace CustomReportParameterType.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Designer() {
            var report = new XtraReport();
            report.Extensions[SerializationService.Guid] = CustomDataSerializer.Name;
            return View(report);
        }

        public ActionResult Viewer() {
            var report = new XtraReport1();
            report.Extensions[SerializationService.Guid] = CustomDataSerializer.Name;
            return View(report);
        }
    }
}