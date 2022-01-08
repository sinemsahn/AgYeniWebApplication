using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AgYeniWebApplication
{
    public partial class AdminAnaSayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object kullanici = Session["Ad"];
            if(kullanici == null)
            {
                Response.Redirect("AdminLoginSayfasi.aspx");
            }
            else
            {
                string ad = "Admin";
                Session.Add("kullanici",ad);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("yorumsilme.aspx");
        }

       

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("urunsilme.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("AdminLoginSayfasi.aspx");

        }
    }
}