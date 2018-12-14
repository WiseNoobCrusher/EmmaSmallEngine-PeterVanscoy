<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Deliveries_Edit.aspx.cs" Inherits="EmmaSmallEngine.Deliveries_Edit" %>

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
            <h1>Edit Delivery:</h1>
            <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>&nbsp<asp:Label ID="lblcustFirst" runat="server"></asp:Label><br />
            <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>&nbsp<asp:Label ID="lblcustLast" runat="server"></asp:Label><br />
            <asp:Label ID="Label3" runat="server" Text="Phone #:"></asp:Label>&nbsp<asp:Label ID="lblcustPhone" runat="server"></asp:Label><br />
            <asp:Label ID="Label4" runat="server" Text="Address:"></asp:Label>&nbsp<asp:Label ID="lblcustAddress" runat="server"></asp:Label><br />
            <asp:Label ID="Label5" runat="server" Text="City:"></asp:Label>&nbsp<asp:Label ID="lblcustCity" runat="server"></asp:Label><br />
            <asp:Label ID="Label6" runat="server" Text="Postal Code"></asp:Label>&nbsp<asp:Label ID="lblcustPostal" runat="server"></asp:Label><br />
            <asp:Label ID="Label7" runat="server" Text="Order Number:"></asp:Label>&nbsp<asp:Label ID="lblordNumber" runat="server"></asp:Label><br />
            <asp:Label ID="Label12" runat="server" Text="Order Date"></asp:Label>&nbsp<asp:Label ID="lblordDate" runat="server"></asp:Label><br />
            <asp:Label ID="Label8" runat="server" Text="Product Name:"></asp:Label>&nbsp<asp:Label ID="lblprodName" runat="server"></asp:Label><br />
            <asp:Label ID="Label10" runat="server" Text="Product Description"></asp:Label>&nbsp<asp:Label ID="lblprodDescription" runat="server"></asp:Label><br />
            <asp:Button runat="server" ID="btnEdit" type="Submit" Text="Submit" OnClick="btnEdit_Click" />
        </div>
    </form>
</body>
</html>
