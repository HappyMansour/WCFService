<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Client.aspx.cs" Inherits="Web_Client.Client" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 121px;
        }
        .auto-style2 {
            width: 301px;
        }
        .auto-style3 {
            width: 115px;
        }
        .auto-style4 {
            width: 268435104px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table style="width:100%;">
            <tr>
                <td colspan="6">
                    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="View_btn" runat="server" OnClick="View_btn_Click" Text="View" />
                </td>
                <td colspan="2">
                    <asp:Button ID="Update_btn" runat="server" Text="Update" />
                </td>
                <td class="auto-style4" colspan="2">
                    <asp:Button ID="Delete_btn" runat="server" Text="Delete" />
                </td>
                <td>
                    <asp:Button ID="Search_btn" runat="server" Text="Search By ID" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">Employee ID:</td>
                <td class="auto-style2" colspan="2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">Employee Name:</td>
                <td class="auto-style2" colspan="2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">Department:</td>
                <td class="auto-style2" colspan="2">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">&nbsp;</td>
                <td class="auto-style2" colspan="2">
                    <asp:Button ID="Insert_btn" runat="server" Text="Insert" />
                </td>
                <td colspan="2">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
