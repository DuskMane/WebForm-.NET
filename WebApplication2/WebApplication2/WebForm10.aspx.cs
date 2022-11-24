using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int satir = Convert.ToInt32(TextBox1.Text);
            int sutun = Convert.ToInt32(TextBox2.Text);
            for(int i =0;i < satir; i++)
            {
                TableRow yeni_satir = new TableRow();
                Table1.Rows.Add(yeni_satir);
                for(int j = 0;j < sutun; j++)
                {
                    TableCell yeni_hucre = new TableCell();
                    yeni_hucre.Text = "Hücre: ["+i.ToString() + ","+ j.ToString()+"]";
                    yeni_hucre.BorderStyle = BorderStyle.Solid;
                    yeni_hucre.BackColor = System.Drawing.Color.Bisque;
                    yeni_satir.Cells.Add(yeni_hucre);
                }
            }
        }
    }
}