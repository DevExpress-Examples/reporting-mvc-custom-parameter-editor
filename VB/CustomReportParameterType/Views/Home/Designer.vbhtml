@ModelType DevExpress.XtraReports.UI.XtraReport

<script type="text/html" id="custom-parameter-editor">
    <div data-bind="dxTextBox: { value: value }, dxValidator: { validationRules: [{ type: 'email', message: 'Email is not valid.' }]}"></div>
</script>
<script type="text/javascript">
    function reportDesignerInit(sender, e) {
        var editor = { header: "custom-parameter-editor" };
        sender.AddParameterType({
            displayValue: "Custom Type",
            specifics: "custom",
            value: "@GetType(CustomReportParameterType.Services.CustomParameterType).FullName",
            valueConverter: function(valueObj) { return valueObj; }
        }, editor);
    }
</script>


@Html.DevExpress().ReportDesigner(Sub(settings)
                                           settings.Name = "ReportDesigner1"
                                           settings.ClientSideEvents.Init = "reportDesignerInit"
                                       End Sub).Bind(Model).GetHtml()
