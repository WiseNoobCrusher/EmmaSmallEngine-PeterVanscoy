<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repairs_Insert.aspx.cs" Inherits="EmmaSmallEngine.Repairs_Insert" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Emma's Small Engine - Insert Customer</title>
    <link rel="stylesheet" href="~/css/styles.css" />
</head>
<body class="Font">
    <form id="login" runat="server">
        <div>
            <asp:Image class="Banner" ID="LoginBanner" runat="server" ImageUrl="~/img/logo.png" />
        </div>
        <br />
        <div align="center">
            <h1>Create New Reapir Order:</h1>
        <asp:Label ID="Label1" runat="server" Text="Order Number:"></asp:Label>&nbsp<asp:Label ID="lblordNumber" runat="server"></asp:Label><br />
            <asp:Label ID="Label2" runat="server" Text="Order Date:"></asp:Label>&nbsp<asp:Label ID="lblordDate" runat="server"></asp:Label><br />
            <asp:Label ID="Label3" runat="server" Text="Service Order Date In:"></asp:Label>&nbsp<asp:Label ID="lblserordDateIn" runat="server"></asp:Label><br />
            <asp:Label ID="Label4" runat="server" Text="Service Order Date Out:"></asp:Label>&nbsp<asp:Label ID="lblserordDateOut" runat="server"></asp:Label><br />
            <asp:Label ID="Label5" runat="server" Text="Service Order Issue:"></asp:Label>&nbsp<asp:Label ID="lblserordIssue" runat="server"></asp:Label><br />
            <asp:Label ID="Label6" runat="server" Text="Service Order Warrenty:"></asp:Label>&nbsp<asp:Label ID="lblserordWarrenty" runat="server"></asp:Label><br />
            <asp:Label ID="Label7" runat="server" Text="Service Name:"></asp:Label>&nbsp<asp:Label ID="lblserName" runat="server"></asp:Label><br />
             <asp:Label ID="Label8" runat="server" Text="Service Description:"></asp:Label>&nbsp<asp:Label ID="lblserDescription" runat="server"></asp:Label><br />
            <asp:Label ID="Label10" runat="server" Text="Service Price:"></asp:Label>&nbsp<asp:Label ID="lblserPrice" runat="server"></asp:Label><br />
             <asp:Label ID="Label12" runat="server" Text="Order Paid:"></asp:Label>&nbsp<asp:Label ID="lblordPaid" runat="server"></asp:Label><br />
            <asp:Label ID="Label9" runat="server" Text="Customer:"></asp:Label>&nbsp<asp:Label ID="lblCustomer" runat="server"></asp:Label><br />

            <asp:Button runat="server" ID="btnInsert" type="Submit" Text="Submit" OnClick="btnInsert_Click" />
        </div>
    </form>
</body>
</html>
