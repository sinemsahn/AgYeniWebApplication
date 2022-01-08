using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace AgYeniWebApplication
{
    public partial class AdminLoginSayfasi : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection(WebConfigurationManager.ConnectionStrings["Veritabani"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from Admin where Ad=@P1 and Parola=@P2",baglanti);
            cmd.Parameters.AddWithValue("@P1", TextBox1.Text);
            cmd.Parameters.AddWithValue("@P2", TextBox2.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session.Add("Ad", TextBox1.Text);
                Response.Redirect("AdminAnaSayfa.aspx");
                

            }
            else
            {
                Label1.Text = "Hatalı kullanıcı adı veya parola! Lütfen tekrar deneyiniz... ";
            }

         
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("AnaSayfa.aspx");
            Session.Abandon();
        }
    }
}