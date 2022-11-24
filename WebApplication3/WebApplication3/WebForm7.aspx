<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication3.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><asp:Label ID="Label1" runat="server" Text="Kişi Numarası :"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddKisi" runat="server">
                            <asp:ListItem Value="1">Ken J</asp:ListItem>
                            <asp:ListItem Value="2">Terri Lee</asp:ListItem>
                            <asp:ListItem Value="3">Roberto </asp:ListItem>
                            <asp:ListItem Value="4">Rob</asp:ListItem>
                            <asp:ListItem Value="5">Gail A</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Telefon Numarası: "></asp:Label></td>
                    <td><asp:TextBox ID="txtel" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Telefon Tipi :"></asp:Label></td>
                    <td><asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="1">Cep Telefonu</asp:ListItem>
                        <asp:ListItem Value="2">Ev Telefonu</asp:ListItem>
                        <asp:ListItem Value="3">İş Telefonu</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btndelete" runat="server" Text="Sil" BackColor="Red" Font-Size="14pt" ForeColor="White" />
                        <asp:Button ID="btnsave" runat="server" BackColor="Lime" Font-Size="14pt" ForeColor="White" Text="Kaydet" OnClick="btnsave_Click" />
                        <br />
                        <br />
                        <asp:Label ID="lblresult" runat="server" Font-Bold="True" Text=""></asp:Label>
                        <br />
                        <br />
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataKeyNames="BusinessEntityID" GridLines="None" OnRowCommand="GridView1_RowCommand">
                            <Columns>
                                <asp:BoundField DataField="BusinessEntityID" HeaderText="Müşteri No" />
                                <asp:BoundField DataField="PhoneNumber" HeaderText="Telefon Numarası" />
                                <asp:BoundField DataField="PhoneNumberTypeID" HeaderText="Telefon Türü" />
                                <asp:BoundField DataField="ModifiedDate" HeaderText="Güncelleme Tarihi" />
                                <asp:CommandField ShowSelectButton="True" />
                            </Columns>
                            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#594B9C" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#33276A" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
