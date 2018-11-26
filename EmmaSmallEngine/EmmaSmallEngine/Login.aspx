<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinalAssignment.Login" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Emma's Small Engine - Login</title>
    <link rel="stylesheet" href="~/css/styles.css" />
</head>
<body class="Font">
    <form id="login" runat="server">
        <div class="Banner">
        <asp:Image ID="logo" runat="server" ImageUrl="~/img/logo.png" Width="200px" style="text-align: left" />
            <br />
            Emma&#39;s Small Engine<br />
        </div>
    <div style="text-align: center">
        <span class="PageFontSize">
        <br />
        Login</span><br />
        <br />
        <table class="LoginForm">
            <tr>
                <td class="TextBoxLabels">Username:</td>
                <td style="text-align: right">
                    <asp:TextBox ID="txtUser" runat="server" Height="20px" Width="160px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="textBoxLabels">Password:</td>
                <td style="text-align: right">
                    <asp:TextBox ID="txtPass" runat="server" TextMode="Password" Height="20px" Width="160px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Height="60px" style="font-size: medium; font-weight: 700" Width="130px" />
        &nbsp;
        <asp:Button ID="btnRegister" runat="server" CausesValidation="False" Text="Register" OnClick="btnRegister_Click" Height="60px" style="font-size: medium; font-weight: 700" Width="130px" />
        <br />
        <br /><span class="PageFontSize">
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUser" ErrorMessage="Username is required" style="color: #CC3300"></asp:RequiredFieldValidator>
        <br /><br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPass" ErrorMessage="Password is required" style="color: #CC3300"></asp:RequiredFieldValidator>
        </span>
    
    </div>
    </form>
</body>
</html>
