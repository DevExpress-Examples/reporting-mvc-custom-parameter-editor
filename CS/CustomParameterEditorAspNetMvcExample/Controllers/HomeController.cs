using DevExpress.XtraReports.Native;
using System.Web.Mvc;

namespace CustomParameterEditorAspNetMvcExample.Controllers
{
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Designer() {
            var report = new DevExpress.XtraReports.UI.XtraReport();
            report.Extensions[SerializationService.Guid] = CustomDataSerializer.Name;
            return View(report);
        }

        public ActionResult Viewer() {
            return View();
        }
    }
}
