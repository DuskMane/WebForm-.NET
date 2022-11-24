<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication2.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Lütfen bir takım seçin:<br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Galatasaray</asp:ListItem>
                <asp:ListItem>Fenerbahçe</asp:ListItem>
                <asp:ListItem>Beşiktaş</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            Lütfen bir araba markası seçin:<asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>BMW</asp:ListItem>
                <asp:ListItem>Mercedes</asp:ListItem>
                <asp:ListItem>Volvo</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Gönder" />
            <br />
            Takım: <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            Araba:
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
