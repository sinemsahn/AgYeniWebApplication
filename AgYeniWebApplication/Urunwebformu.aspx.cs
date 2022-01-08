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
    public partial class Urunwebformu : System.Web.UI.Page

    {
    

        protected void Page_Load(object sender, EventArgs e)
        {
            //burada gelen isme göre oluşturuulmuş olan tablodaki tüm verileri çekeceğim
            //burada sql çalıştırıp tüm ürünleri çekip yansıtalım
            SqlConnection baglantii = new SqlConnection(WebConfigurationManager.ConnectionStrings["Veritabani"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglantii;
            string kelime = Request.QueryString["urun"].ToString();
            Console.WriteLine(kelime);
            string sql = @"select * from Yorumlar Where UrunAdiYorum ="+"'"+ kelime+"'";

            cmd.CommandText = sql;
            Console.WriteLine(sql);
            baglantii.Open();
            SqlDataReader dr = cmd.ExecuteReader();
           

            lstUrunYorum.DataSource = dr;
                lstUrunYorum.DataBind();
                

            
       


            baglantii.Close();

            //burada sql çalıştırıp tüm ürünleri çekip yansıtalım

            var deger = Request.QueryString["id"];
            string sqll = "select * from Resimler where ID =" + deger;


            baglantii.Open();
            cmd.CommandText = sqll;
            dr = cmd.ExecuteReader();
            
                lstUrun.DataSource = dr;
                lstUrun.DataBind();

            

            baglantii.Close();

        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kelime = Request.QueryString["urun"].ToString();
            var deger = Request.QueryString["id"];
            string hrefaddr = "YorumWebForm.aspx?urunadi=" + kelime + "&" + "idim=" + deger;

            Response.Redirect(hrefaddr);

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnaSayfa.aspx");
        }

        
    }
}