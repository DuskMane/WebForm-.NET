using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                Label1.Text = CheckBox1.Text + " seçildi.";
            }
            else
            {
                Label1.Text = "";
            }
        }
        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
            {
                Label2.Text = CheckBox2.Text + " seçildi.";
            }
            else
            {
                Label2.Text = "";
            }
        }
        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked)
            {
                Label3.Text = CheckBox3.Text + " seçildi.";
            }
            else
            {
                Label3.Text = "";
            }
        }

        
    }
}