<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewCars.aspx.cs" Inherits="MyWebGallery.samples.GridViewCars" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="grdCars" runat="server" AutoGenerateColumns="False" 
             OnRowDataBound="grdCars_RowDataBound">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkPrint" runat="server">印刷</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <b><%# Eval("Name") %></b>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemStyle Width="200px" />
                    <ItemTemplate>
                        <span style="background-color:lightslategray;"><%# Eval("Maker") %></span><br />
                        <span><%# Eval("Price") %></span>
                    </ItemTemplate>
                    
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
