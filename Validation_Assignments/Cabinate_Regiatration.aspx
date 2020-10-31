<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cabinate_Regiatration.aspx.cs" Inherits="WebApplication5.Cabinate_Regiatration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Candidate Name</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" Width="321px" BackColor="#CCFFFF"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Fname is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Email</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server" Width="321px" BackColor="#CCFFFF"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="lname is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Class</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server" Width="321px" BackColor="#CCFFFF"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="It is required field" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="class should be in between 6 to 12" ForeColor="#FF3300" MaximumValue="12" MinimumValue="6" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style1">House</td>
                <td class="auto-style2">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" >
                        <asp:ListItem>Red</asp:ListItem>
                        <asp:ListItem>Blue</asp:ListItem>
                        <asp:ListItem>Green</asp:ListItem>
                        <asp:ListItem>Yellow</asp:ListItem>
                    </asp:RadioButtonList>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="choose any House Please" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                     <br />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="Silver" ForeColor="Red" />
                </td>
                 <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" BackColor="#66FFFF" ForeColor="#003399" />
                    <br />
                    <br />
 
                </td>
                                  
            </tr>
        </table>

        </div>
    </form>
</body>
</html>
