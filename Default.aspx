<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 289px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 110px;
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
    
        <table style="width:100%; height: 250px;">
            <tr>
                <td class="auto-style1" colspan="1.5">
                    <table style="width:100%;">
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
                            </td>
                  
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="Label2" runat="server" Text="UserName"></asp:Label>
                            </td>
                            <td class="auto-style2">
                                <asp:TextBox ID="User_Name" runat="server"></asp:TextBox>
                            </td>
                  
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                            </td>
                            <td class="auto-style2">
                                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                </td>
                <td colspan="1.5">&nbsp;</td>
            </tr>
           
        </table>
    
    </div>
    </form>
</body>
</html>
