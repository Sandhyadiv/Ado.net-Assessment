using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FootWearAssessment.DatabaseConnection;


namespace FootWearAssessment
{
    public partial class OrderUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FootwearDB obj = new FootwearDB();
            FootWearModel footwearModelObj = new FootWearModel();
            DataTable dt = new DataTable();
            dt = obj.Status();
            GVStatus.DataSource = dt;
            GVStatus.DataBind();
        }

       
    }
}