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
    public partial class yorumsilme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //diğerine benzer olarak yorum silme ve editleme ekleriz
            object user = Session["kullanici"];
            if (user == null)
            {
                Response.Redirect("AdminLoginSayfasi.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(WebConfigurationManager.ConnectionStrings["Veritabani"].ToString());
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Yorumlar (UrunAdiYorum, YorumAdi, Yorum) Values (@P1, @P2, @P3)", baglanti);
            cmd.Parameters.AddWithValue("@P1", TextBox1.Text);
            cmd.Parameters.AddWithValue("@P2", TextBox2.Text);
            cmd.Parameters.AddWithValue("@P3", TextBox3.Text);
            cmd.ExecuteNonQuery();

            baglanti.Close();
            Response.Redirect("urunsilme.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAnaSayfa.aspx");
        }
    }
}