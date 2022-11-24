using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(RadioButtonList1.SelectedIndex != -1)
            {
                Label1.Text = RadioButtonList1.SelectedItem.Text;
            }
            else
            {
                Label1.Text = "Favori takımınızı seçin.";
            }

            if (RadioButtonList2.SelectedIndex != -1)
            {
                Label2.Text = RadioButtonList2.SelectedItem.Text;
            }
            else
            {
                Label2.Text = "Favori araba markanızı seçin.";
            }
        }
    }
}