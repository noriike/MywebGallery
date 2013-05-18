<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BingSearch.aspx.cs" Inherits="MyWebGallery.samples.BingSearch.BingSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style type="text/css">
        .SearchBox {
            width:300px;
            margin-top:50px;
            margin-left:auto;
            margin-right:auto;
        }
        .SearchTxtBox {
            width:240px;
        }
        .SearchResult {
            width:1000px;
            margin-left:auto;
            margin-right:auto;
        }
        .resultitem {
            width:800px;
            margin-left:auto;
            margin-right:auto;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="SearchBox">
            <asp:TextBox ID="txtSearch" runat="server" CssClass="SearchTxtBox"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="検索" OnClick="btnSearch_Click" />
            <div>
                <asp:RadioButton ID="rdbWeb" runat="server" GroupName="searchoption" Text="Web" Checked="true" />
                <asp:RadioButton ID="rdbImge" runat="server" GroupName="searchoption" Text="Image" />
            </div>
        </div>

        <div class="SearchResult">
            <asp:GridView ID="grdResult" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label runat="server" CssClass="resultitem" Text='<%# Eval("title") %>'></asp:Label>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("Url") %>'>'<%# Eval("title") %>'</asp:HyperLink>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Url") %>' Width="300px" />
                        </ItemTemplate>
                        

                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
    </form>
</body>
</html>
