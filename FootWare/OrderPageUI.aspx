<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderPageUI.aspx.cs" Inherits="FootWearAssessment.OrderPageUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Product Code"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:Label ID="lblProductCode" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Product Name"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:Label ID="lblProductName" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Quantity"></asp:Label></td>
                    <td>:</td>
                    <td>
                        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnBill" runat="server" Text="Show Bill" OnClick="btnBill_Click" /></td>
                </tr>
            </table>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Total Amount : "></asp:Label>
            <asp:Label ID="lblTotalAmount" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnPayment" runat="server" Text="Payment" OnClick="btnPayment_Click" />
        </div>
    </form>
</body>
</html>
