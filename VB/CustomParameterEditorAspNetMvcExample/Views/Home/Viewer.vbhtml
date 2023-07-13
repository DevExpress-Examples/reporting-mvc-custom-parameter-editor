
<script type="text/html" id="custom-parameter-text-editor">
    <div data-bind="dxTextBox: getOptions({ value: value, disabled: disabled }),
         dxValidator: { validationRules: $data.validationRules || [] }"></div>
</script>
<script type="text/javascript">
    function customizeParameterEditors(s, e) {
        if (e.parameter.type ===
            "@GetType(CustomParameterEditorAspNetMvcExample.CustomParameterType).FullName") {
            if(!e.parameter.multiValue && !e.parameter.hasLookUpValues) {
                e.info.validationRules = e.info.validationRules || [];
                e.info.validationRules.push(
                    { type: 'email', message: 'Email parameter value has invalid format.' });
                e.info.editor = { header: "custom-parameter-text-editor" };
            }
        }
    }
</script>

@Html.DevExpress().WebDocumentViewer(
    Sub(settings)
        settings.Name = "WebDocumentViewer1"
        settings.ClientSideEvents.CustomizeParameterEditors = "customizeParameterEditors"
    End Sub).Bind("CustomReport").GetHtml()
