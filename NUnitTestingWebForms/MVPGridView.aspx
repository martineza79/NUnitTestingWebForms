<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MVPGridView.aspx.cs" Inherits="NUnitTestingWebForms.MVPGridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="true" AutoGenerateColumns="true" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="true" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            </Columns>
        </asp:GridView>

        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="NUnitTestingWebForms.ObjectSourceBusinessObject">
        </asp:ObjectDataSource>

        
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox></div>
    </form>
</body>
</html>
