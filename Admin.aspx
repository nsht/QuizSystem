<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
     <header>
    <div class="nav">
      <ul>
        <li class="home"><a href="Default">Home</a></li>
        <li class="admin"><a class="active" href="adminLogin.aspx">Admin</a></li>
        <li class="register"><a href="register.aspx">Register</a></li>
        <li class="about"><a href="about.aspx">About</a></li>
      </ul>
    </div>
  </header>
   <div class="containerf">
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Manage Users" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Manage Questions" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
