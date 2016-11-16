<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Userhome.aspx.cs" Inherits="Userhome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 127px;
        }
    </style>
</head>
<body>
    <header>
    <div class="nav">
      <ul>
       <li class="home"><a class="active" href="#">Home</a></li>
        <li class="admin"><a href="adminLogin.aspx">Admin</a></li>
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
                <td class="auto-style1">
                    <asp:Label ID="Label1" runat="server" Text="Welcome"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="userLabel" runat="server" Text="Label"></asp:Label>
                </td>
               
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="takeTest" runat="server" Text="Take Test" OnClick="Button1_Click" />
                </td>
               
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="marks" runat="server" Text="Show Marks" OnClick="marks_Click" />
                </td>
               
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
