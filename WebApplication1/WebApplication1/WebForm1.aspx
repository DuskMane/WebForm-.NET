<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<script runat="server">
    Protected void checkbox1_checkedChange(Object sender, EventArgs e){
        
    }
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
        </div>
    <table style="width:100%;">
        <tr>
            <td>Ürünler:</td>
            <td>Seçimleriniz:</td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Bilgisayar" />
            </td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:CheckBox ID="CheckBox2" runat="server" />
            </td>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox3" runat="server" />
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>
