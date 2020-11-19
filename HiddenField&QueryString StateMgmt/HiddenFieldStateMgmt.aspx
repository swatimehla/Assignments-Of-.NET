<%@ Page Trace="true" Language="C#" AutoEventWireup="true" CodeBehind="HiddenFieldStateMgmt.aspx.cs" Inherits="WebStateMangement.WebCount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Height="83px"  OnClick="Button1_Click" Text="Hit Count" Width="162px" />
            <asp:HiddenField ID="HiddenField1" runat="server"  value="0"/>
            <asp:Button ID="Button2" runat="server" PostBackUrl="~/GetHiddenFieldValues.aspx" Text="For GetValue" OnClick="Button2_Click" />
            <br />
            <br />
        </div>
        

        <div>
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
                    <td>    <asp:Button ID="Button3" runat="server" Text="Login" OnClick="Button3_Click" />
                            &nbsp;
                            <asp:Button ID="Button4" runat="server" Text="Reset" OnClick="Button4_Click" />
                            </td>
                    <td></td>
                </tr>
            </table>
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:HiddenField ID="HiddenField2" runat="server"  value="0"/>
            <asp:HiddenField ID="HiddenField3" runat="server"  value="0"/>
            <br />
            <asp:Button ID="Button5" runat="server" Text="Click Me" OnClick="Button5_Click" />
                            <br />
            <asp:HiddenField ID="HiddenField4" runat="server"  value="0"/>
            <br />
            <asp:Button ID="Button6" runat="server" Text="Click Me Also " OnClick="Button6_Click" />
            <br />
            <asp:HiddenField ID="HiddenField5" runat="server"  value="0"/>
            &nbsp;<br />
            <br />

            <br />
        </div>
    </form>
</body>
</html>
