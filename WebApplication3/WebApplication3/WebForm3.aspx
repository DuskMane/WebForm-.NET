<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication3.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="BusinessEntityID" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="BusinessEntityID" HeaderText="1" />
                    <asp:BoundField DataField="PhoneNumber" HeaderText="2" />
                    <asp:BoundField DataField="PhoneNumberTypeID" HeaderText="3" />
                    <asp:BoundField DataField="ModifiedDate" HeaderText="4" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorks2019ConnectionString %>" 
            SelectCommand="SELECT TOP (100) BusinessEntityID, PhoneNumber, PhoneNumberTypeID, ModifiedDate FROM Person.PersonPhone ORDER BY BusinessEntityID DESC"
            UpdateCommand="UPDATE Person.PersonPhone set [PhoneNumber]= @PhoneNumber, [PhoneNumberTypeID]= @PhoneNumberTypeID, [ModifiedDate]= @ModifiedDate  where [BusinessEntityID]= @BusinessEntityID" 
            DeleteCommand="DELETE FROM Person.PersonPhone WHERE (BusinessEntityID = @BusinessEntityID)" 
            InsertCommand="INSERT INTO Person.PersonPhone(PhoneNumber, PhoneNumberTypeID, ModifiedDate) VALUES (@PhoneNumber, @TypeID, @MDate)"
            >
            <DeleteParameters>
                <asp:Parameter Name="BusinessEntityID" Type="Int32" />
            </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="PhoneNumber" />
                    <asp:Parameter Name="TypeID" />
                    <asp:Parameter Name="MDate" />
                </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="PhoneNumber" Type="String" />
                <asp:Parameter Name="BusinessEntityID" Type="Int32" />
                <asp:Parameter Name="PhoneNumberTypeID" Type="Int32" />
                <asp:Parameter Name="ModifiedDate" Type="DateTime" />

            </UpdateParameters>

            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
