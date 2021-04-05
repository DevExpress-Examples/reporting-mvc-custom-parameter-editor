Option Infer On

Imports CustomReportParameterType.Services
Imports DevExpress.XtraReports.Parameters
Imports System.Collections.Generic

Partial Public Class XtraReport1
	Inherits DevExpress.XtraReports.UI.XtraReport

	Public Sub New()
		InitializeComponent()

		Dim staticListLookUpSettings1 = New StaticListLookUpSettings()
		Dim staticListLookUpSettings2 = New StaticListLookUpSettings()
		' 
		' customMailParameterLookup
		' 
		customMailParameterLookup.Description = "Custom Email Parameter"
		customMailParameterLookup.Name = "customMailParameterLookup"
		customMailParameterLookup.Type = GetType(CustomParameterType)
		Dim parameterLookUpValue1 = New CustomParameterType With {.Value = "MyFirtsMail@example.com"}
		Dim parameterLookUpValue2 = New CustomParameterType With {.Value = "MySecondMail@example.com"}
		staticListLookUpSettings1.LookUpValues.AddRange(New List(Of LookUpValue) From {
			New LookUpValue(parameterLookUpValue1, "First Mail Value"),
			New LookUpValue(parameterLookUpValue2, "Second Mail Value")
		})
		customMailParameterLookup.ValueSourceSettings = staticListLookUpSettings1
		' 
		' customMailParameterText
		' 
		customMailParameterText.Description = "Additional Custom Email Parameter"
		customMailParameterText.Name = "customMailParameterText"
		customMailParameterText.Type = GetType(CustomParameterType)
		customMailParameterText.Value = New CustomParameterType With {.Value = "SampleMail@example.com"}
		' 
		' customMailParameterMultivalue
		' 
		customMailParameterMultivalue.Description = "Multi-value Email Parameter"
		customMailParameterMultivalue.MultiValue = True
		customMailParameterMultivalue.Name = "customMailParameterMultivalue"
		customMailParameterMultivalue.Type = GetType(CustomParameterType)
		customMailParameterMultivalue.Value = New List(Of CustomParameterType) From {
			New CustomParameterType With {.Value = "FirstSampleMail@example.com"},
			New CustomParameterType With {.Value = "SecondSampleMail@example.com"}
		}
		' 
		' customMailParameterMultivalueLookup
		' 
		customMailParameterMultivalueLookup.Description = "Predefined multi-value Email parameter"
		customMailParameterMultivalueLookup.MultiValue = True
		customMailParameterMultivalueLookup.Name = "customMailParameterMultivalueLookup"
		customMailParameterMultivalueLookup.Type = GetType(CustomParameterType)
		Dim parameterLookUpValue3 = New CustomParameterType With {.Value = "MyThirdMail@example.com"}
		Dim parameterLookUpValue4 = New CustomParameterType With {.Value = "MyFourthMail@example.com"}
		staticListLookUpSettings2.LookUpValues.AddRange(New List(Of LookUpValue) From {
			New LookUpValue(parameterLookUpValue3, "Third Mail Value"),
			New LookUpValue(parameterLookUpValue4, "Fourth Mail Value")
		})
		customMailParameterMultivalueLookup.ValueSourceSettings = staticListLookUpSettings2
	End Sub
End Class
