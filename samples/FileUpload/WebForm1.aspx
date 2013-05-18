<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MyWebGallery.samples.FileUpload.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <div>
            <asp:Button ID="btnSave" runat="server" Text="登録" OnClick="btnSave_Click" />
        </div>
        <div>
            <asp:Button ID="btnRead" runat="server" Text="表示" OnClick="btnRead_Click" />
        </div>
    </div>
        
    </form>
</body>
</html>
