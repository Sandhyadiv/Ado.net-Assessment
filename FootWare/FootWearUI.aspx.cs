using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FootWearAssessment.DatabaseConnection;
using System.Data.SqlClient;
using System.Data;

namespace FootWearAssessment
{
    public partial class FootWearUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnselect_Click(object sender, EventArgs e)
        {
            FootwearDB obj = new FootwearDB();
            FootWearModel footwearModelObj = new FootWearModel();
            footwearModelObj.Category = DropDownList1.SelectedValue;
            DataTable dt = new DataTable();
            dt = obj.SelectCategory(footwearModelObj);
            gvDisplay.DataSource = dt;
            gvDisplay.DataBind();


        }
        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Session["value"] = txtProCode.Text;
            Response.Redirect("OrderPageUI.aspx");
        }

        protected void btnStatus_Click(object sender, EventArgs e)
        {
           
                Response.Redirect("OrderUI.aspx");
          
        }
    }
}