<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PopUp.aspx.cs" Inherits="MyWebGallery.samples.Ajax.PopUp" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <ajaxToolkit:ToolkitScriptManager runat="server"></ajaxToolkit:ToolkitScriptManager>
    <div>
        <div >
            <asp:TextBox ID="txtCarId" runat="server" AutoPostBack="True" OnTextChanged="txtCarId_TextChanged"></asp:TextBox>
            <asp:Label ID="lblCarName" runat="server" Text=""></asp:Label>
        </div>

<%--        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="MyWebGallery.resources.Data.car.CarDao" SelectMethod="Load"></asp:ObjectDataSource>
        <ajaxToolkit:ComboBox ID="ComboBox1" runat="server" AutoCompleteMode="SuggestAppend" DataSourceID="ObjectDataSource1" DropDownStyle="DropDown" AutoPostBack="True" OnItemInserted="ComboBox1_ItemInserted"></ajaxToolkit:ComboBox>

        <ajaxToolkit:PopupControlExtender ID="txtCarId_PopupControlExtender" runat="server" DynamicServicePath="" Enabled="True" ExtenderControlID="" PopupControlID="pnlCars" TargetControlID="txtCarId" CacheDynamicResults="True" Position="Right">
        </ajaxToolkit:PopupControlExtender>--%>
        
        <asp:Panel ID="pnlCars" runat="server">
            <div id="listContnainer" runat="server" style="width:300px;border-style:solid;border-width:1px;">
                <div style="width:300px;">
                    <asp:Label ID="Label1" runat="server" Text="名前:"></asp:Label>
                    <asp:TextBox ID="txtName" runat="server" OnTextChanged="txtName_TextChanged" Width="200px"></asp:TextBox>
                    <asp:Button ID="btnSelect" runat="server" Text="選択" />
                    <asp:ListBox ID="lstCars" runat="server" Width="300px" Height="300px"></asp:ListBox>
                </div>
            </div>
        </asp:Panel>

        
    </div>
    </form>
</body>
</html>
