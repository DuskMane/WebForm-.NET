<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Kitap</asp:ListItem>
            <asp:ListItem>CD</asp:ListItem>
            <asp:ListItem>Poster</asp:ListItem>
            <asp:ListItem>Bilgisayar</asp:ListItem>
            <asp:ListItem>Kırtasiye</asp:ListItem>
            <asp:ListItem>DVD</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="true" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Tablo halinde göster" />
        &nbsp;<asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="true" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Yatay göster" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Gönder" onclick="buton_tiklandi"/>
        <br />
        <br />
        Seçimleriniz: <asp:Label ID="Label1" runat="server" Text="Seçim"></asp:Label>
    </form>
</body>
</html>
