using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FootWearAssessment.DatabaseConnection;

namespace FootWearAssessment
{
    public partial class OrderPageUI : System.Web.UI.Page
    {
        FootwearDB obj = new FootwearDB();
        FootWearModel footwearModelObj = new FootWearModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            FootwearDB obj = new FootwearDB();

            if (!IsPostBack)
            {
                lblProductCode.Text = "" + Session["value"];
                footwearModelObj.ProductCode = Convert.ToInt32(Session["value"]);
                StatusProperty status = obj.Fetch(footwearModelObj);

                lblProductName.Text = status.ProductName;
                lblPrice.Text = status.Cost.ToString();
            }
        }

        protected void btnBill_Click(object sender, EventArgs e)
        {
            footwearModelObj.ProductCode = Convert.ToInt32(Session["value"]);

            StatusProperty status = obj.Fetch(footwearModelObj);
            int Quantity = Convert.ToInt32(txtQuantity.Text);
            lblTotalAmount.Text = Convert.ToString(status.Cost * Quantity);
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            StatusProperty status = new StatusProperty();
            status.ProductCode = Convert.ToInt32(lblProductCode.Text);
            status.ProductName = lblProductName.Text;
            status.Cost = Convert.ToInt32(lblPrice.Text);
            status.Quantity = Convert.ToInt32(txtQuantity.Text);
            status.TotalAmount = Convert.ToInt32(lblTotalAmount.Text);
            string msg = obj.Payment(status);
            Response.Write($"<script>alert('{msg}')</script>");
        }
    }
}