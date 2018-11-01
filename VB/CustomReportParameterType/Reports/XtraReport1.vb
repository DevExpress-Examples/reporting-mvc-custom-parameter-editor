Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.Parameters
Imports CustomReportParameterType.Services
Imports System.Collections.Generic

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    Private Detail As DevExpress.XtraReports.UI.DetailBand
    Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Private Title As XRControlStyle
    Private DetailCaption3 As XRControlStyle
    Private DetailData3 As XRControlStyle
    Private DetailData3_Odd As XRControlStyle
    Private DetailCaptionBackground3 As XRControlStyle
    Private PageInfo As XRControlStyle
    Private customMailParameterLookup As DevExpress.XtraReports.Parameters.Parameter
    Private xrLabel3 As XRLabel
    Private xrLabel2 As XRLabel
    Private customMailParameterText As DevExpress.XtraReports.Parameters.Parameter
    Private customMailParameterMultivalue As DevExpress.XtraReports.Parameters.Parameter
    Private customMailParameterMultivalueLookup As DevExpress.XtraReports.Parameters.Parameter
    Private staticListLookUpSettings1 As New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
    Private staticListLookUpSettings2 As New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
    Private xrLabel10 As XRLabel
    Private xrLabel8 As XRLabel
    Private xrLabel9 As XRLabel
    Private xrLabel6 As XRLabel
    Private xrLabel7 As XRLabel
    Private xrLabel4 As XRLabel
    Private xrLabel5 As XRLabel

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        InitializeComponent()
        '
        ' TODO: Add constructor logic here
        '
        Dim parameterLookUpValue1 = New CustomParameterType With {.Value = "MyFirtsMail@mail.com"}
        Dim parameterLookUpValue2 = New CustomParameterType With {.Value = "MySecondMail@mail.com"}
        Me.staticListLookUpSettings1.LookUpValues.Add(New LookUpValue(parameterLookUpValue1, "First Mail Value"))
        Me.staticListLookUpSettings1.LookUpValues.Add(New LookUpValue(parameterLookUpValue2, "Second Mail Value"))

        Me.customMailParameterText.Value = New CustomParameterType With {.Value = "SampleMail@mail.com"}

        Me.customMailParameterMultivalue.Value = New List(Of CustomParameterType) From { _
            New CustomParameterType With {.Value = "FirstSampleMail@mail.com"}, _
            New CustomParameterType With {.Value = "SecondSampleMail@mail.com"} _
        }

        Dim parameterLookUpValue3 = New CustomParameterType With {.Value = "MyThirdMail@mail.com"}
        Dim parameterLookUpValue4 = New CustomParameterType With {.Value = "MyFourthMail@mail.com"}
        Me.staticListLookUpSettings2.LookUpValues.Add(New LookUpValue(parameterLookUpValue3, "Third Mail Value"))
        Me.staticListLookUpSettings2.LookUpValues.Add(New LookUpValue(parameterLookUpValue4, "Fourth Mail Value"))
    End Sub

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    #Region "Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaption3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailCaptionBackground3 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.customMailParameterLookup = New DevExpress.XtraReports.Parameters.Parameter()
        Me.customMailParameterText = New DevExpress.XtraReports.Parameters.Parameter()
        Me.customMailParameterMultivalue = New DevExpress.XtraReports.Parameters.Parameter()
        Me.customMailParameterMultivalueLookup = New DevExpress.XtraReports.Parameters.Parameter()
        DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' Detail
        ' 
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel8, Me.xrLabel9, Me.xrLabel6, Me.xrLabel7, Me.xrLabel4, Me.xrLabel5, Me.xrLabel3, Me.xrLabel10})
        Me.Detail.HeightF = 289.7084F
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' TopMargin
        ' 
        Me.TopMargin.HeightF = 78.20841F
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' xrLabel10
        ' 
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
        Me.xrLabel10.Multiline = True
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(249.4583F, 25.55338F)
        Me.xrLabel10.StyleName = "Title"
        Me.xrLabel10.Text = "Send this report to:"
        ' 
        ' xrLabel8
        ' 
        Me.xrLabel8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[customMailParameterMultivalueLookup]")})
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(377.4291F, 227.125F)
        Me.xrLabel8.Multiline = True
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(262.5709F, 62.58339F)
        Me.xrLabel8.Text = "xrLabel2"
        ' 
        ' xrLabel9
        ' 
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0F, 227.125F)
        Me.xrLabel9.Multiline = True
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(377.4291F, 62.58336F)
        Me.xrLabel9.StyleName = "Title"
        Me.xrLabel9.StylePriority.UseTextAlignment = False
        Me.xrLabel9.Text = "Multiple email addresses (predefined list):"
        Me.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' xrLabel6
        ' 
        Me.xrLabel6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[customMailParameterMultivalue]")})
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(377.4291F, 171.9166F)
        Me.xrLabel6.Multiline = True
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(262.5709F, 23F)
        Me.xrLabel6.Text = "xrLabel2"
        ' 
        ' xrLabel7
        ' 
        Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0F, 169.3633F)
        Me.xrLabel7.Multiline = True
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel7.SizeF = New System.Drawing.SizeF(377.4291F, 25.55339F)
        Me.xrLabel7.StyleName = "Title"
        Me.xrLabel7.StylePriority.UseTextAlignment = False
        Me.xrLabel7.Text = "Multiple email addresses:"
        Me.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' xrLabel4
        ' 
        Me.xrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[customMailParameterText]")})
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(377.4291F, 115.2083F)
        Me.xrLabel4.Multiline = True
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(262.5709F, 28.20834F)
        Me.xrLabel4.Text = "xrLabel2"
        ' 
        ' xrLabel5
        ' 
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0F, 115.2083F)
        Me.xrLabel5.Multiline = True
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(377.4291F, 28.20834F)
        Me.xrLabel5.StyleName = "Title"
        Me.xrLabel5.StylePriority.UseTextAlignment = False
        Me.xrLabel5.Text = "Single email address:"
        Me.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' xrLabel3
        ' 
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0F, 47.91667F)
        Me.xrLabel3.Multiline = True
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(377.4291F, 55.29165F)
        Me.xrLabel3.StyleName = "Title"
        Me.xrLabel3.StylePriority.UseTextAlignment = False
        Me.xrLabel3.Text = "Single email address (predefined list):"
        Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' xrLabel2
        ' 
        Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[customMailParameterLookup]")})
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(377.4291F, 47.91667F)
        Me.xrLabel2.Multiline = True
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(262.5709F, 55.29165F)
        Me.xrLabel2.Text = "xrLabel2"
        ' 
        ' BottomMargin
        ' 
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        ' 
        ' Title
        ' 
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.BorderColor = System.Drawing.Color.Black
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1F
        Me.Title.Font = New System.Drawing.Font("Tahoma", 14F)
        Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
        Me.Title.Name = "Title"
        ' 
        ' DetailCaption3
        ' 
        Me.DetailCaption3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.BorderColor = System.Drawing.Color.Transparent
        Me.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailCaption3.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
        Me.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
        Me.DetailCaption3.Name = "DetailCaption3"
        Me.DetailCaption3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
        Me.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        ' 
        ' DetailData3
        ' 
        Me.DetailData3.Font = New System.Drawing.Font("Tahoma", 8F)
        Me.DetailData3.ForeColor = System.Drawing.Color.Black
        Me.DetailData3.Name = "DetailData3"
        Me.DetailData3.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
        Me.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        ' 
        ' DetailData3_Odd
        ' 
        Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(231)))), (CInt((CByte(231)))), (CInt((CByte(231)))))
        Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
        Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DetailData3_Odd.BorderWidth = 1F
        Me.DetailData3_Odd.Font = New System.Drawing.Font("Tahoma", 8F)
        Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
        Me.DetailData3_Odd.Name = "DetailData3_Odd"
        Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
        Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        ' 
        ' DetailCaptionBackground3
        ' 
        Me.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent
        Me.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(206)))), (CInt((CByte(206)))), (CInt((CByte(206)))))
        Me.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.DetailCaptionBackground3.BorderWidth = 2F
        Me.DetailCaptionBackground3.Name = "DetailCaptionBackground3"
        ' 
        ' PageInfo
        ' 
        Me.PageInfo.Font = New System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
        Me.PageInfo.Name = "PageInfo"
        Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
        ' 
        ' customMailParameterLookup
        ' 
        Me.customMailParameterLookup.Description = "Custom Email Parameter"
        Me.customMailParameterLookup.LookUpSettings = staticListLookUpSettings1
        Me.customMailParameterLookup.Name = "customMailParameterLookup"
        Me.customMailParameterLookup.Type = GetType(CustomReportParameterType.Services.CustomParameterType)
        ' 
        ' customMailParameterText
        ' 
        Me.customMailParameterText.Description = "Additional Custom Email Parameter"
        Me.customMailParameterText.Name = "customMailParameterText"
        Me.customMailParameterText.Type = GetType(CustomReportParameterType.Services.CustomParameterType)
        ' 
        ' customMailParameterMultivalue
        ' 
        Me.customMailParameterMultivalue.Description = "Multi-value Email Parameter"
        Me.customMailParameterMultivalue.MultiValue = True
        Me.customMailParameterMultivalue.Name = "customMailParameterMultivalue"
        Me.customMailParameterMultivalue.Type = GetType(CustomReportParameterType.Services.CustomParameterType)
        ' 
        ' customMailParameterMultivalueLookup
        ' 
        Me.customMailParameterMultivalueLookup.Description = "Predefined multi-value Email parameter"
        Me.customMailParameterMultivalueLookup.LookUpSettings = staticListLookUpSettings2
        Me.customMailParameterMultivalueLookup.MultiValue = True
        Me.customMailParameterMultivalueLookup.Name = "customMailParameterMultivalueLookup"
        Me.customMailParameterMultivalueLookup.Type = GetType(CustomReportParameterType.Services.CustomParameterType)
        Me.customMailParameterMultivalueLookup.ValueInfo = "MyThirdMail@mail.com"
        ' 
        ' XtraReport1
        ' 
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 78, 100)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.customMailParameterLookup, Me.customMailParameterText, Me.customMailParameterMultivalue, Me.customMailParameterMultivalueLookup})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.DetailCaption3, Me.DetailData3, Me.DetailData3_Odd, Me.DetailCaptionBackground3, Me.PageInfo})
        Me.Version = "18.2"
        DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    #End Region
End Class
