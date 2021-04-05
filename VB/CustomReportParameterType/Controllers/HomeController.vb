#Region "usings"
Imports CustomReportParameterType.Services
Imports DevExpress.XtraReports.Native
Imports DevExpress.XtraReports.UI
Imports System.Web.Mvc
#End Region ' usings

Namespace CustomReportParameterType.Controllers
	#Region "#controller_Home"
	Public Class HomeController
		Inherits Controller

		#End Region
		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function Designer() As ActionResult
			Dim report = New XtraReport()
			report.Extensions(SerializationService.Guid) = CustomDataSerializer.Name
			Return View(report)
		End Function
		#Region "action_Viewer"
		Public Function Viewer() As ActionResult
			Dim report = New XtraReport1()
			report.Extensions(SerializationService.Guid) = CustomDataSerializer.Name
			Return View(report)
		End Function
		#End Region
	End Class
End Namespace
