partial class XtraReport1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaptionBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.customMailParameterLookup = new DevExpress.XtraReports.Parameters.Parameter();
            this.customMailParameterText = new DevExpress.XtraReports.Parameters.Parameter();
            this.customMailParameterMultivalue = new DevExpress.XtraReports.Parameters.Parameter();
            this.customMailParameterMultivalueLookup = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel3,
            this.xrLabel10});
            this.Detail.HeightF = 289.7084F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[customMailParameterLookup]")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(377.4291F, 47.91667F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(262.5709F, 55.29165F);
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[customMailParameterMultivalueLookup]")});
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(377.4291F, 227.125F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(262.5709F, 62.58339F);
            this.xrLabel8.Text = "xrLabel2";
            // 
            // xrLabel9
            // 
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 227.125F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(377.4291F, 62.58336F);
            this.xrLabel9.StyleName = "Title";
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Multiple email addresses (predefined list):";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[customMailParameterMultivalue]")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(377.4291F, 171.9166F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(262.5709F, 23F);
            this.xrLabel6.Text = "xrLabel2";
            // 
            // xrLabel7
            // 
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 169.3633F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(377.4291F, 25.55339F);
            this.xrLabel7.StyleName = "Title";
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Multiple email addresses:";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[customMailParameterText]")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(377.4291F, 115.2083F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(262.5709F, 28.20834F);
            this.xrLabel4.Text = "xrLabel2";
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 115.2083F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(377.4291F, 28.20834F);
            this.xrLabel5.StyleName = "Title";
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Single email address:";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 47.91667F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(377.4291F, 55.29165F);
            this.xrLabel3.StyleName = "Title";
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Single email address (predefined list):";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(249.4583F, 25.55338F);
            this.xrLabel10.StyleName = "Title";
            this.xrLabel10.Text = "Send this report to:";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 78.20841F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            // 
            // DetailCaption3
            // 
            this.DetailCaption3.BackColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.BorderColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailCaption3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption3.Name = "DetailCaption3";
            this.DetailCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3
            // 
            this.DetailData3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.DetailData3.ForeColor = System.Drawing.Color.Black;
            this.DetailData3.Name = "DetailData3";
            this.DetailData3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new System.Drawing.Font("Tahoma", 8F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailCaptionBackground3
            // 
            this.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent;
            this.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.DetailCaptionBackground3.BorderWidth = 2F;
            this.DetailCaptionBackground3.Name = "DetailCaptionBackground3";
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // customMailParameterLookup
            // 
            this.customMailParameterLookup.Description = "Custom Email Parameter";
            this.customMailParameterLookup.Name = "customMailParameterLookup";
            // 
            // customMailParameterText
            // 
            this.customMailParameterText.Description = "Additional Custom Email Parameter";
            this.customMailParameterText.Name = "customMailParameterText";
            // 
            // customMailParameterMultivalue
            // 
            this.customMailParameterMultivalue.Description = "Multi-value Email Parameter";
            this.customMailParameterMultivalue.MultiValue = true;
            this.customMailParameterMultivalue.Name = "customMailParameterMultivalue";
            // 
            // customMailParameterMultivalueLookup
            // 
            this.customMailParameterMultivalueLookup.Description = "Predefined multi-value Email parameter";
            this.customMailParameterMultivalueLookup.MultiValue = true;
            this.customMailParameterMultivalueLookup.Name = "customMailParameterMultivalueLookup";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 78, 100);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.customMailParameterLookup,
            this.customMailParameterText,
            this.customMailParameterMultivalue,
            this.customMailParameterMultivalueLookup});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption3,
            this.DetailData3,
            this.DetailData3_Odd,
            this.DetailCaptionBackground3,
            this.PageInfo});
            this.Version = "21.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    private DevExpress.XtraReports.UI.XRLabel xrLabel8;
    private DevExpress.XtraReports.UI.XRLabel xrLabel9;
    private DevExpress.XtraReports.UI.XRLabel xrLabel6;
    private DevExpress.XtraReports.UI.XRLabel xrLabel7;
    private DevExpress.XtraReports.UI.XRLabel xrLabel4;
    private DevExpress.XtraReports.UI.XRLabel xrLabel5;
    private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    private DevExpress.XtraReports.UI.XRLabel xrLabel10;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.XRControlStyle Title;
    private DevExpress.XtraReports.UI.XRControlStyle DetailCaption3;
    private DevExpress.XtraReports.UI.XRControlStyle DetailData3;
    private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
    private DevExpress.XtraReports.UI.XRControlStyle DetailCaptionBackground3;
    private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
    private DevExpress.XtraReports.Parameters.Parameter customMailParameterLookup;
    private DevExpress.XtraReports.Parameters.Parameter customMailParameterText;
    private DevExpress.XtraReports.Parameters.Parameter customMailParameterMultivalue;
    private DevExpress.XtraReports.Parameters.Parameter customMailParameterMultivalueLookup;
}
