<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStringStateMgmt.aspx.cs" Inherits="StateMangementWebDemo.webForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        

        <div><h2>Login Here</h2>
            <table>
                <tr>
                    <td>UserName </td>
                    <td> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td> <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                            &nbsp;
                            <asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" /></td>
                    <td></td>
                </tr>
            </table>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />

            <br />
        </div>
        <div><h2>Registration Pgae</h2>
             <table>
                <tr>
                    <td>UserName </td>
                    <td> <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email </td>
                    <td> <asp:TextBox ID="TextBox4" runat="server" TextMode="Email"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td> <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>Branch</td>
                    <td> <asp:TextBox ID="TextBox6" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>    <asp:Button ID="Button3" runat="server" Text="Register" OnClick="Button3_Click" />
                            
                     <td></td>
                </tr>
            </table>
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
