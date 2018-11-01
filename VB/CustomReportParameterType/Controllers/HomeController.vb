Imports CustomReportParameterType.Services
Imports DevExpress.DataAccess.Sql
Imports DevExpress.XtraReports.Native

Namespace CustomReportParameterType.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function Designer() As ActionResult
            Dim report = New XtraReport()
            report.Extensions(SerializationService.Guid) = CustomDataSerializer.Name
            Return View(report)
        End Function

        Public Function Viewer() As ActionResult
            Dim report = New XtraReport1()
            report.Extensions(SerializationService.Guid) = CustomDataSerializer.Name
            Return View(report)
        End Function
    End Class
End Namespace