<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication2.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem>Adana</asp:ListItem>
                <asp:ListItem>İstanbul</asp:ListItem>
                <asp:ListItem>Ankara</asp:ListItem>
                <asp:ListItem>Bursa</asp:ListItem>
                <asp:ListItem>İzmir</asp:ListItem>
            </asp:ListBox>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnCommand="komut" CommandName="listele" CommandArgument="artarak_listele" Text="Artarak Listele" OnClick="Button_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnCommand="komut" CommandName="listele" CommandArgument="azalarak_listele" Text="Azalarak Listele" OnClick="Button_Click" />
        <br />
        <br />
        Tıklanan buton:
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server">LinkedIn</asp:HyperLink>
    </form>
</body>
</html>
