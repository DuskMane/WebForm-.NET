using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] sehir = { "Adana", "Ankara", "İstanbul", "İzmir", "Konya" };
            if (!Page.IsPostBack)
            {
                for (int i = 0; i < sehir.Length; i++)
                {
                    ListBox1.Items.Add(sehir[i]);
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                ListBox2.Items.Add(ListBox1.SelectedItem.Text);
                ListBox1.Items.Remove(ListBox1.SelectedItem.Text);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ListBox2.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                ListBox1.Items.Add(ListBox2.SelectedItem.Text);
                ListBox2.Items.Remove(ListBox2.SelectedItem.Text);
            }
        }
    }
}