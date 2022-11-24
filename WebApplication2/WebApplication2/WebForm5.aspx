<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication2.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="&lt;" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="&gt;" OnClick="Button2_Click" />
&nbsp;<asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
        </div>
    </form>
</body>
</html>
