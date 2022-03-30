<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBing.aspx.cs" Inherits="WangBowen0227WebApplication.lecture13.DataBing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownListYesNo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownYesNo_SelectedIndexChanged" ViewStateMode="Disabled">
                <asp:ListItem Value="Yes">Yes</asp:ListItem>
                <asp:ListItem Value="No">No</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:ListBox ID="ListBoxTowns" runat="server" AutoPostBack="True" DataTextField="Name" DataValueField="ID" OnSelectedIndexChanged="ListBoxTowns_SelectedIndexChanged"></asp:ListBox>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
