<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer_Edit.aspx.cs" Inherits="EmmaSmallEngine.Customer_Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Emma's Small Engine - Edit Customer</title>
    <link rel="stylesheet" href="~/css/styles.css" />
</head>
<body class="Font">
    <form id="login" runat="server">
        <div>
            <asp:Image class="Banner" ID="LoginBanner" runat="server" ImageUrl="~/img/logo.png" />
        </div>
        <div align="center">
            <h1>Edit Customer:</h1>
            <asp:Label ID="Label1" runat="server" Text="First Name: "></asp:Label>&nbsp;<asp:TextBox ID="txtFirst" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Last Name: "></asp:Label>&nbsp;<asp:TextBox ID="txtLast" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label3" runat="server" Text="Phone Number: "></asp:Label>&nbsp;<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label4" runat="server" Text="Address: "></asp:Label>&nbsp;<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label5" runat="server" Text="City: "></asp:Label>&nbsp;<asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label6" runat="server" Text="Postal Code: "></asp:Label>&nbsp;<asp:TextBox ID="txtPostal" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label7" runat="server" Text="Email Address: "></asp:Label>&nbsp;<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br /><br />
            <asp:Button runat="server" ID="btnEdit" type="Submit" Text="Submit" OnClick="btnEdit_Click" />
        </div>
    </form>
</body>
</html>
