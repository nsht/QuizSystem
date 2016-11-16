<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dMarks.aspx.cs" Inherits="dMarks" %>

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
       <li class="home"><a class="active" href="#">Home</a></li>
        <li class="admin"><a href="adminLogin.aspx">Admin</a></li>
        <li class="register"><a href="register.aspx">Register</a></li>
        <li class="about"><a href="about.aspx">about</a></li>
      </ul>
    </div>
  </header>
   <div class="containerf">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="You Scored"></asp:Label>
        <br />
    
        <asp:Label ID="dMarksL" runat="server" Text="Label"></asp:Label>
    
        %</div>
    </form>
</body>
</html>
