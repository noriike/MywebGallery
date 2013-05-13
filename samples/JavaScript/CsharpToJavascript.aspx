<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CsharpToJavascript.aspx.cs" Inherits="MyWebGallery.samples.JavaScript.CsharpToJavascript" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <script type="text/javascript">
        function calltest(ClientId) {
            if (confirm("画面遷移しますか？")) {
                __doPostBack('Button2', '');
            }
            else {
                return false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </ajaxToolkit:ToolkitScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>

                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

                <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        
    </div>
    </form>
</body>
</html>
