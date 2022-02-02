using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace FootWearAssessment.DatabaseConnection
{
    public class FootwearDB
    {
        string sqlConnectionstr = "Data Source=100.72.130.5;Initial Catalog=350562_Dev;User ID=350562;Password=350562";
        public DataTable SelectCategory(FootWearModel footwearModel)
        {
            SqlConnection sqlConnectionObj = new SqlConnection(sqlConnectionstr);
            SqlCommand sqlCommandOj = new SqlCommand($"select ProductCode,ProductName,Cost from FootWear_SV where Category= '{ footwearModel.Category}'", sqlConnectionObj);
            sqlConnectionObj.Open();
            SqlDataReader sqlDataReader = sqlCommandOj.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlConnectionObj.Close();
            return dt;
        }
        public StatusProperty Fetch(FootWearModel footwearModel)
        {
            StatusProperty status = new StatusProperty();
            SqlConnection con = new SqlConnection(sqlConnectionstr);
            SqlDataAdapter da = new SqlDataAdapter($"select * from FootWear_SA where ProductCode = {footwearModel.ProductCode} ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            status.ProductCode = Convert.ToInt32(dt.Rows[0][0]);
            status.ProductName = dt.Rows[0][1].ToString();
            status.Cost = Convert.ToInt32(dt.Rows[0][2]);
            return status;
        }
        
        public string Payment(StatusProperty status)
        {
            SqlConnection con = new SqlConnection(sqlConnectionstr);
            con.Open();
            SqlCommand cmd = new SqlCommand($"insert into OrderPage_SA values({status.ProductCode},'{status.ProductName}',{status.Cost},{status.Quantity},{status.TotalAmount})", con); ;
            cmd.ExecuteNonQuery();
            con.Close();
            return "Saved Succesfully";
        }
        public DataTable Status()
        {
            SqlConnection con = new SqlConnection(sqlConnectionstr);
            SqlDataAdapter da = new SqlDataAdapter("select * from OrderPage_VB", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}