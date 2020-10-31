<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_RegisrationForm.aspx.cs" Inherits="WebApplication5.Validations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 322px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
            <tr>
                <td class="auto-style1">First Name</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server" Width="321px" BackColor="#FFFFCC"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Fname is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Last Name</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server" Width="321px" BackColor="#FFFFCC"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="lname is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Father&#39;s Name</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server" Width="321px" BackColor="#FFFFCC"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="It is required field" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Mother&#39;s Name</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox4" runat="server" Width="321px" BackColor="#FFFFCC"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="It is required field" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Aggregate Marks(%)</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox5" runat="server" Width="321px" BackColor="#FFFFCC" ForeColor="Black"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="its is required" ForeColor="Red"></asp:RequiredFieldValidator>
                &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="aggregate marks should be greater than 60" ForeColor="#FF3300" MaximumValue="100" MinimumValue="60" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style1">Course</td>
                <td class="auto-style2">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                        <asp:ListItem>CSE</asp:ListItem>
                        <asp:ListItem>ECE</asp:ListItem>
                    </asp:RadioButtonList>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="choose any course please" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="data structure" Visible="False" />
                    <br />
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="DBMS" Visible="False" />
                    <br />
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="Automata" Visible="False" />
&nbsp;<br />
                    <asp:CheckBox ID="CheckBox4" runat="server" Text="Microproceesor" Visible="False" />
                    <br />
                    <asp:CheckBox ID="CheckBox5" runat="server" Text="Digital Electronics" Visible="False" />
                    <br />
                    <asp:CheckBox ID="CheckBox6" runat="server" Text="Data communication" Visible="False" />
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Please choose anyone course " OnServerValidate="CustomValidator1_ServerValidate1" ForeColor="Red"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                     <br />
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="Silver" ForeColor="Red" />
                </td>
                 <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" BackColor="#FFFF99" ForeColor="#003399" />
                    <br />
                    <br />
 
                </td>
                

                   
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
