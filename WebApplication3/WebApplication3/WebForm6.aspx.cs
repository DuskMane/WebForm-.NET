using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        private string connectionString = @"Data Source=FIGEN;Initial Catalog=eticaret;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = DataKaynagiAdabtorGetir();
            GridView1.DataBind();
        }
        //datareader
        private DataTable GetDataSource()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            if(connection.State == ConnectionState.Open)
            {
                var cmd = new SqlCommand("Select * from tblurun", connection);

                DataTable dt = new DataTable();
                dt.TableName = "Urun";
                dt.Columns.Add("urunID");
                dt.Columns.Add("urunadi");
                dt.Columns.Add("fiyat");
                dt.Columns.Add("kategori");
                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    var row = dt.NewRow();
                    row[0] = Convert.ToInt32(reader["urunID"]);
                    row[1] = (reader["urunadi"]).ToString();
                    row[2] = (reader["fiyat"]).ToString();
                    row[3] = (reader["kategori"]).ToString();
                    dt.Rows.Add(row);
                }
                reader.Close();
                connection.Close();
                return dt;

           }
            return null;
        }

        private DataTable DataKaynagiAdabtorGetir()
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();

            if(connection.State == ConnectionState.Open)
            {
                var cmd = new SqlCommand("select * from tblurun", connection);
                var adaptor = new SqlDataAdapter(cmd);
                var dset = new DataSet();
                adaptor.Fill(dset);
                return dset.Tables[0];
            }

            return null;
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType== DataControlRowType.DataRow)
            {
                string kategori = e.Row.Cells[3].Text;
                if( kategori == "1")
                {
                    e.Row.Cells[3].Text = "Bilgisayar";
                }
                else if(kategori == "2")
                {
                    e.Row.Cells[3].Text = "Telefon";
                }
            }
        }
    }
}