using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] sehir = { "Adana", "Ankara", "İstanbul", "İzmir", "Konya" };
            if (!Page.IsPostBack)
            {
                for(int i = 0; i < sehir.Length; i++)
                {
                    DropDownList1.Items.Add(sehir[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            if (DropDownList1.SelectedIndex == 0)
            {
                DropDownList2.Items.Add("Çukurova");
                DropDownList2.Items.Add("Yüreğir");
                DropDownList2.Items.Add("Sarıçam");
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                DropDownList2.Items.Add("Ankara 1");
                DropDownList2.Items.Add("Ankara 2");
                DropDownList2.Items.Add("Ankara 3");
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                DropDownList2.Items.Add("İstanbul 1");
                DropDownList2.Items.Add("İstanbul 2");
                DropDownList2.Items.Add("İstanbul 3");
            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                DropDownList2.Items.Add("İzmir 1");
                DropDownList2.Items.Add("İzmir 2");
                DropDownList2.Items.Add("İzmir 3");
            }
            else if (DropDownList1.SelectedIndex == 4)
            {
                DropDownList2.Items.Add("Konya 1");
                DropDownList2.Items.Add("Konya 2");
                DropDownList2.Items.Add("Konya 3");
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedItem.Text + ", "+ DropDownList2.SelectedItem.Text;
        }
    }
}