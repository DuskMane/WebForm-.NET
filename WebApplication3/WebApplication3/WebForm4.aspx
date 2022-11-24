<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication3.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyField="personelID" DataSourceID="SqlDataSource1" GridLines="Both">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <ItemTemplate>
                    <table>
                        <tr>
                            <!-- Resim -->
                            <td>
                                <asp:Image ID="Image1" ImageUrl='<%# Eval("RESIM") %>' runat="server" />
                            </td>
                            <!-- özellik etiketi -->
                            <td>
                                ADI:
                                <br />
                                SOYADI:
                                <br />
                                TELEFON:
                                <br />
                                TCKIMLIKNO:
                                <br />
                                MAAS:
                                <br />
                                ADRES:
                                <br />
                                SEMT:
                                <br />
                                SEHIR:
                                <br />
                                GIRISTARIHI:
                                <br />
                                CIKISTARIHI:
                                <br />
                                EMAIL:
 
                                <br />
                            </td>
                            <!-- özellik değeri -->
                            <td>
                                <asp:Label ID="Label12" runat="server" Text='<%# Eval("ADI") %>' />
                                <br />
                                <asp:Label ID="Label13" runat="server" Text='<%# Eval("SOYADI") %>' />
                                <br />
                                <asp:Label ID="Label14" runat="server" Text='<%# Eval("TELEFON") %>' />
                                <br />
                                <asp:Label ID="Label15" runat="server" Text='<%# Eval("TCKIMLIKNO") %>' />
                                <br />
                                <asp:Label ID="Label16" runat="server" Text='<%# Eval("MAAS") %>' />
                                <br />
                                <asp:Label ID="Label17" runat="server" Text='<%# Eval("ADRES") %>' />
                                <br />
                                <asp:Label ID="Label18" runat="server" Text='<%# Eval("SEMT") %>' />
                                <br />
                                <asp:Label ID="Label19" runat="server" Text='<%# Eval("SEHIR") %>' />
                                <br />
                                <asp:Label ID="Label20" runat="server" Text='<%# Eval("GIRISTARIHI") %>' />
                                <br />
                                <asp:Label ID="Label21" runat="server" Text='<%# Eval("CIKISTARIHI") %>' />
                                <br />
                                <asp:Label ID="Label22" runat="server" Text='<%# Eval("EMAIL") %>' />
                                <br />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            </asp:DataList>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eticaretConnectionString %>" 
            SelectCommand="SELECT * FROM [tblPersonel]">

        </asp:SqlDataSource>
    </form>
</body>
</html>
