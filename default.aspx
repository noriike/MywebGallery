<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="MywebGallery.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>おいらの実験場</title>
    <link href="styles/default.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        

        <div>
            <div class="header">
                <h1>これはおいらの実験場です</h1>
            </div>
            <div class="body">
                <table>
                    <tr>
                        <td>
                            <a href="samples/GridView/GridViewCars.aspx">GridView</a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="samples/Ajax/PopUp.aspx">Ajax</a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="samples/JavaScript/CsharpToJavascript.aspx">Javascript呼び出し</a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="samples/GridViewDetail/WebForm1.aspx">griddetail</a>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="samples/FileUpload/WebForm1.aspx">FileUpload</a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="samples/BingSearch/BingSearch.aspx">BingSearch</a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="samples/HttpResponse/WebForm1.aspx">HttpResponse Jpeg</a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="samples/HttpResponse/WebForm2.aspx">HttpResponse text/CSV</a>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="footer">

            </div>
        </div>

    </div>
    </form>
</body>
</html>
