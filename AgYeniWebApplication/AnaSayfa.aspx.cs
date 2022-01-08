using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Configuration;
using System.Data.SqlClient;

namespace AgYeniWebApplication
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["Veritabani"].ToString());
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = conn;
            cmdd.CommandText = "select * from Resimler";
            conn.Open();
            SqlDataReader dr = cmdd.ExecuteReader();
            lstUrun.DataSource = dr;
            lstUrun.DataBind();

            conn.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["Veritabani"].ToString());
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = conn;
            string kelime = TextBox1.Text;
            cmdd.CommandText = "select * from Resimler Where ResimAdi= "+"'"+kelime +"'";
            conn.Open();
            SqlDataReader dr = cmdd.ExecuteReader();
            lstUrun.DataSource = dr;
            lstUrun.DataBind();

            conn.Close();

        }
    }
}