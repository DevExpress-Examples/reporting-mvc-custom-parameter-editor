Imports DevExpress.XtraReports.Native

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function
    Function Designer() As ActionResult
        Dim report = New DevExpress.XtraReports.UI.XtraReport()
        report.Extensions(SerializationService.Guid) = CustomDataSerializer.Name
        Return View(report)
    End Function
    Function Viewer() As ActionResult
        Return View()
    End Function
End Class
