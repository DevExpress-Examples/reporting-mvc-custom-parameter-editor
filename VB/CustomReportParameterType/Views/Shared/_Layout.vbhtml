<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>DevExpress ASP.NET project</title>
    
    @Html.DevExpress().GetStyleSheets(
                                New StyleSheet With {.ExtensionType = ExtensionType.ReportDesigner}
                )
    @Html.DevExpress().GetScripts(
                    New Script With {.ExtensionType = ExtensionType.ReportDesigner}
                )
</head>

<body>
    <div class="content-wrapper">
        <div class="header">
            <h1>DevExpress ASP.NET project</h1>
        </div>

        <div class="content">
            @RenderBody()
        </div>

        <div class="footer">
            <p>&copy; @DateTime.Now.Year - DevExpress ASP.NET project copyright</p>
        </div>
    </div>
</body>
</html>
