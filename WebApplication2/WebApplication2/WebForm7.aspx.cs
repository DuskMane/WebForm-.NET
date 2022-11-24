using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.NavigateUrl = "https://tr.linkedin.com/in/emirhan-aykan";
            HyperLink1.Target = "_blank";
        }

        protected void komut(object sender, CommandEventArgs e)
        {
            string[] sehir = new string[ListBox1.Items.Count];
            for(int i = 0; i< sehir.Length; i++)
            {
                sehir[i] = ListBox1.Items[i].Text;
            }
            if(e.CommandName=="listele" && (string)e.CommandArgument == "artarak_listele")
            {
                Array.Sort(sehir);
                for (int i = 0; i < sehir.Length; i++)
                {
                    ListBox1.Items[i].Text = sehir[i];
                }
            }
            else if (e.CommandName == "listele" && (string)e.CommandArgument == "azalarak_listele")
            {
                Array.Sort(sehir);
                Array.Reverse(sehir);
                for (int i = 0; i < sehir.Length; i++)
                {
                    ListBox1.Items[i].Text = sehir[i];
                }
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Label1.Text = ((Button)sender).Text;
        }
    }
}