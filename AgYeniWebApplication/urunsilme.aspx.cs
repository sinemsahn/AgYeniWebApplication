using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace AgYeniWebApplication
{
    public partial class urunsilme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object user = Session["kullanici"];
            if (user == null)
            {
                Response.Redirect("AdminLoginSayfasi.aspx");
            }
        }

        protected void Button1_Click(object sender,EventArgs e)
        {

            SqlConnection baglantii = new SqlConnection(WebConfigurationManager.ConnectionStrings["Veritabani"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglantii;

            string resim = TextBox1.Text;
            string resimadi = TextBox2.Text;
            string hakkindabigi = TextBox3.Text;
           

            string sql = @"insert into Resimler " + "(Resim, ResimAdi, HakkindaBilgi) values(" + "'" + resim + "'" + " , " + "'" + resimadi + "'" + " , " + "'" + hakkindabigi + "'" + " )";
            Console.WriteLine(sql);
            cmd.CommandText = sql;
            baglantii.Open();
            cmd.ExecuteNonQuery();
            baglantii.Close();
            Response.Redirect("urunsilme.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAnaSayfa.aspx");
        }
    }
}
