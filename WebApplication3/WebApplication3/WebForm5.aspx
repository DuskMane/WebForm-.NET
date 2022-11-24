<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication3.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
                <ItemTemplate>
                    <asp:Image ID="Image1" ImageUrl='<%# Eval("resim") %>' Height="150px" Width="150px" runat="server" />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("urunID") %>'></asp:Label>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("urunadi") %>'></asp:Label>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("fiyat") %>'></asp:Label>
                    <br />
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("kategori") %>'></asp:Label>
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:eticaretConnectionString %>" 
            SelectCommand="SELECT urunID, urunadi, fiyat, resim, kategori FROM tblurun"></asp:SqlDataSource>
    </form>
</body>
</html>
