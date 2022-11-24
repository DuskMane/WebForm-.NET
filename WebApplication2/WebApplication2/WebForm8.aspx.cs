using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Controls.Add(new LiteralControl("İsim"));
            TextBox isim = new TextBox();
            Panel1.Controls.Add(isim);
            Panel1.Controls.Add(new LiteralControl("<br />"));
            Panel1.Controls.Add(new LiteralControl("Parola"));
            TextBox parola = new TextBox();
            Panel1.Controls.Add(parola);
            Panel1.Controls.Add(new LiteralControl("<br />"));
            Button giris = new Button();
            giris.Text = "Giriş";
            Panel1.Controls.Add(giris);
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Panel1.Visible)
            {
                Panel1.Visible = false;
            }
            else
            {
                Panel1.Visible = true;
            }
        }
    }
}