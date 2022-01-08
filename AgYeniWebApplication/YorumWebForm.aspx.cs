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
    public partial class YorumWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //gelen urunadi kısmından alıp db den insert ekle ve diğer yere yönlendir.
            //gonder butonu basınca çalışmalı
        }
       

        

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglantii = new SqlConnection(WebConfigurationManager.ConnectionStrings["Veritabani"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglantii;
            string kelime = Request.QueryString["urunadi"].ToString();
            string adim = Request.Form["Ad"];
            string soyadim = Request.Form["Soyad"];
            string tam = adim + " " + soyadim;
            string yorumum = Request.Form["Yorum"];

            string sql = @"insert into Yorumlar "  + "(UrunAdiYorum, YorumAdi, Yorumu) values(" +"'"+ kelime +"'"+" , "+"'" + tam + "'" + " , "   +"'"+ yorumum +"'"+ " )";
            Console.WriteLine(sql);
            cmd.CommandText = sql;
            baglantii.Open();
            cmd.ExecuteReader();


            baglantii.Close();

            string sayfam = "Urunwebformu.aspx?urun=" + Request.QueryString["urunadi"] + "&" + "id=" + Request.QueryString["idim"];
            Response.Redirect(sayfam);

        }
    }
}