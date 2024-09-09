using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Invoice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void calculateBtn_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            decimal productCost;
            int quantity;
            decimal previousDebt;
            decimal shippingFee;
            decimal vatRate;

            // Kiểm tra và chuyển đổi các giá trị từ TextBox
            if (!decimal.TryParse(productCostTextBox.Text, out productCost) ||
                !int.TryParse(quantityTextBox.Text, out quantity) ||
                !decimal.TryParse(previousDebtTextBox.Text, out previousDebt) ||
                !decimal.TryParse(shippingFeeTextBox.Text, out shippingFee) ||
                !decimal.TryParse(vatRateTextBox.Text, out vatRate))
            {
                result.InnerText = "Vui lòng nhập dữ liệu hợp lệ!";
                return;
            }

            // Tính toán tổng chi phí
            decimal subtotal = productCost * quantity + previousDebt + shippingFee;
            decimal total = subtotal * (1 + vatRate / 100);

            // Hiển thị kết quả
            result.InnerText = "Tổng chi phí đơn hàng là: " + total.ToString("N2") + " VND";
        }
    }
}