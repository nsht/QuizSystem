<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Test" %>

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
        <li class="about"><a href="about.aspx">About</a></li>
      </ul>
    </div>
  </header>
   <div class="containerf">
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td colspan="3">
                    1)
                    <asp:Label ID="Q" runat="server" Text="Label"></asp:Label>
                    <input id="Button3" type="button" value="Start Test" runat="server" onserverclick="gTest"/></td>
            </tr>
            <tr>
                <td>
                    A)<asp:Label ID="O1" runat="server" Text="Label"></asp:Label>
                    <br />
                    B)<asp:Label ID="O2" runat="server" Text="Label"></asp:Label>
                    <br />
                    C)<asp:Label ID="O3" runat="server" Text="Label"></asp:Label>
                    <br />
                    D)<asp:Label ID="O4" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    
                        <asp:RadioButton ID="RadioButton1" GroupName="Q1" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton2" GroupName="Q1" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton3" GroupName="Q1" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton4" GroupName="Q1" runat="server" />
                    
                </td>
            </tr>
           
        </table>
    
        <hr />
        <br />
    
        <table style="width:100%;">
            <tr>
                <td colspan="2">
                    2)
                    <asp:Label ID="Q0" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    A)<asp:Label ID="O5" runat="server" Text="Label"></asp:Label>
                    <br />
                    B)<asp:Label ID="O6" runat="server" Text="Label"></asp:Label>
                    <br />
                    C)<asp:Label ID="O7" runat="server" Text="Label"></asp:Label>
                    <br />
                    D)<asp:Label ID="O8" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    
                        <asp:RadioButton ID="RadioButton5" GroupName="Q2" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton6" GroupName="Q2" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton7" GroupName="Q2" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton8" GroupName="Q2" runat="server" />
                    
                </td>
            </tr>
           
        </table>
    <hr />
        <table style="width:100%;">
            <tr>
                <td colspan="2">
                    3)
                    <asp:Label ID="Q1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    A)<asp:Label ID="O9" runat="server" Text="Label"></asp:Label>
                    <br />
                    B)<asp:Label ID="O10" runat="server" Text="Label"></asp:Label>
                    <br />
                    C)<asp:Label ID="O11" runat="server" Text="Label"></asp:Label>
                    <br />
                    D)<asp:Label ID="O12" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    
                        <asp:RadioButton ID="RadioButton9" GroupName="Q3" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton10" GroupName="Q3" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton11" GroupName="Q3" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton12" GroupName="Q3" runat="server" />
                    
                </td>
            </tr>
           
        </table>
    
        <br />
        <hr />
        <table style="width:100%;">
            <tr>
                <td colspan="2">
                    4)
                    <asp:Label ID="Q2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    A)<asp:Label ID="O13" runat="server" Text="Label"></asp:Label>
                    <br />
                    B)<asp:Label ID="O14" runat="server" Text="Label"></asp:Label>
                    <br />
                    C)<asp:Label ID="O15" runat="server" Text="Label"></asp:Label>
                    <br />
                    D)<asp:Label ID="O16" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    
                        <asp:RadioButton ID="RadioButton13" GroupName="Q4" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton14" GroupName="Q4" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton15" GroupName="Q4" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton16" GroupName="Q4" runat="server" />
                    
                </td>
            </tr>
           
        </table>
    
        <br />
        <hr />
        <table style="width:100%;">
            <tr>
                <td colspan="2">
                    5)
                    <asp:Label ID="Q3" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    A)<asp:Label ID="O17" runat="server" Text="Label"></asp:Label>
                    <br />
                    B)<asp:Label ID="O18" runat="server" Text="Label"></asp:Label>
                    <br />
                    C)<asp:Label ID="O19" runat="server" Text="Label"></asp:Label>
                    <br />
                    D)<asp:Label ID="O20" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    
                        <asp:RadioButton ID="RadioButton17" GroupName="Q5" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton18" GroupName="Q5" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton19" GroupName="Q5" runat="server" />
                        <br />
                        <asp:RadioButton ID="RadioButton20" GroupName="Q5" runat="server" />
                    
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Show Marks" style="text-align: right" OnClick="Button1_Click" />
                    <input id="Button2" type="button" value="Submit Test" runat="server" onserverclick="Check_t"/></td>
            </tr>
           
        </table>
    
        <br />
        
    </div>
    </form>

     </div>
   
     
   
</body>
</html>
