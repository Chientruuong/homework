<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Invoice.aspx.cs" Inherits="WebApplication2.Invoice" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chương trình tính tổng hoá đơn</title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-12 text-center my-4">
                    <h1>CHƯƠNG TRÌNH TÍNH CHI PHÍ ĐƠN HÀNG</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6 offset-md-3">
                    <div class="form-group">
                        <label for="productCost">Giá sản phẩm:</label>
                        <asp:TextBox ID="productCostTextBox" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="quantity">Số lượng sản phẩm:</label>
                        <asp:TextBox ID="quantityTextBox" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="previousDebt">Số nợ chưa trả từ năm trước:</label>
                        <asp:TextBox ID="previousDebtTextBox" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="shippingFee">Phí vận chuyển:</label>
                        <asp:TextBox ID="shippingFeeTextBox" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="vatRate">Thuế VAT (%):</label>
                        <asp:TextBox ID="vatRateTextBox" runat="server" CssClass="form-control" Text="10" TextMode="Number"></asp:TextBox>
                    </div>
                    <asp:Button ID="calculateBtn" runat="server" CssClass="btn btn-primary btn-block" Text="Tính ngay và luôn" OnClick="calculateBtn_Click" />
                    <div class="mt-3">
                        <h4 id="result" runat="server"></h4>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>