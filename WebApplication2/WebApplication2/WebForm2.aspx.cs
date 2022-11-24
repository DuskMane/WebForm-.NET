using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void buton_tiklandi(object sender, EventArgs e)
        {
            string secilen = "";
            bool firsti = true;
            for(int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                
                if(CheckBoxList1.Items[i].Selected == true)
                {
                    if (firsti)
                    {
                        secilen = CheckBoxList1.Items[i].Text;
                        firsti = false;
                    }
                    else
                    {
                        secilen = secilen + ", " + CheckBoxList1.Items[i].Text;
                    }
                }
            }
            Label1.Text = secilen;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox1.Checked)
            {
                CheckBoxList1.RepeatLayout = RepeatLayout.Table;
            }
            else
            {
                CheckBoxList1.RepeatLayout = RepeatLayout.Flow;
            }
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked)
            {
                CheckBoxList1.RepeatDirection = RepeatDirection.Horizontal;
            }
            else
            {
                CheckBoxList1.RepeatDirection = RepeatDirection.Vertical;
            }
        }
    }
}