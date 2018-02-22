<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exam.aspx.cs" Inherits="Exam2014.Exam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 300px;
            background-color: #FF9966;
        }
        .auto-style3 {
            background-color: #FF9966;
        }
        .auto-style4 {
            width: 300px;
            height: 34px;
            background-color: #FF9966;
        }
        .auto-style5 {
            height: 34px;
            background-color: #FF9966;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3" colspan="3">
                    <h1 style="text-align: center">cellphone contract costing</h1>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Client Name:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    <br />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="btnValidate" runat="server" OnClick="btnValidate_Click" Text="Validate" />
                    <asp:Button ID="btnProcess" runat="server" OnClick="btnProcess_Click" Text="Process" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Cleint Surname:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
                    <br />
                </td>
                <td class="auto-style3">Monthly Premium:<asp:Label ID="lblMonthly" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Number of free apps:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtApps" runat="server"></asp:TextBox>
                    <br />
                </td>
                <td class="auto-style3">Total Premium:<asp:Label ID="lblTotal" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Client Code:</td>
                <td class="auto-style3">
                    <asp:Label ID="lblGenCode" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Smart phone Type:</td>
                <td class="auto-style5">
                    <asp:RadioButton ID="radiPhone" runat="server" GroupName="Type" Text="iPhone6" />
                    <br />
                    <asp:RadioButton ID="radSamsung" runat="server" GroupName="Type" Text="Sumsang Galaxy S6" />
                    <br />
                    <asp:RadioButton ID="radNokia" runat="server" GroupName="Type" Text="Nokia Lumina 1520" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="btnSearch" runat="server" Text="SearchClient" OnClick="Button1_Click" />
                    <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Contract Period:</td>
                <td class="auto-style3">
                    <asp:RadioButton ID="rad12" runat="server" GroupName="Period" Text="12 Months" />
                    <br />
                    <asp:RadioButton ID="rad24" runat="server" GroupName="Period" Text="24 Months" />
                    <br />
                    <asp:RadioButton ID="rad36" runat="server" GroupName="Period" Text="36 Months" />
                </td>
                <td class="auto-style3">
                    <asp:Label ID="lblOutput" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Extras:</td>
                <td class="auto-style3">
                    <asp:CheckBox ID="chkSMS" runat="server" Text="SMS" />
                    <br />
                    <asp:CheckBox ID="chkData" runat="server" Text="Data Bundles" />
                    <br />
                    <asp:CheckBox ID="chkAirtime" runat="server" Text="Airtime" />
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
