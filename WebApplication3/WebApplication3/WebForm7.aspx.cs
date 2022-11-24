using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication3
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        //private string connectionString = @"Data Source=FIGEN;Initial Catalog=eticaret;Integrated Security=True";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                GridYenile();
            }

        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtel.Text))
            {
                lblresult.ForeColor = System.Drawing.Color.Yellow;
                lblresult.Text = "telefon numarası boş olamaz";
                return;
            }
            int id = Convert.ToInt32(ddKisi.SelectedValue);
            string tel = txtel.Text.Trim();
            int type = Convert.ToInt32(DropDownList1.SelectedValue);

            var sorgu = "";
            var dt = TabloGetir($"select phoneNumber from Person.PersonPhone where BusinessEntityID = {id} and PhoneNumber = '{tel}' and PhoneNumberTypeID = {type}");
            if (dt == null || dt.Rows.Count == 0)
            {
                sorgu = "insert into person.personphone(businessentityid, phonenumber, phonenumbertypeid, modifieddate) values (@id,@telefon,@type,@date)";
            }
            else
            {
                sorgu = $"update person.personphone set modifieddate=@date where BusinessEntityID = {id} and PhoneNumber = '{tel}' and PhoneNumberTypeID = {type} ";
            }


            var baglantiMetni = ConfigurationManager.ConnectionStrings["AdventureWorks2019ConnectionString"].ToString();
            var baglanti = new SqlConnection(baglantiMetni);
            baglanti.Open();
            if(baglanti.State == ConnectionState.Open)
            {
                var komut = new SqlCommand(sorgu, baglanti);
                
                DateTime guncellemeTarihi = DateTime.Now;

                var idParam = new SqlParameter("@id", id);
                var telParam = new SqlParameter("@telefon", tel);
                var typeParam = new SqlParameter("@type", type);
                var dateParam = new SqlParameter("@date", guncellemeTarihi);
                komut.Parameters.Add(idParam);
                komut.Parameters.Add(telParam);
                komut.Parameters.Add(typeParam);
                komut.Parameters.Add(dateParam);

                int result = komut.ExecuteNonQuery();

                if(result  > 0)
                {
                    lblresult.ForeColor = System.Drawing.Color.Green;
                    lblresult.Text = $"işlem başarılı. etkilenen satır sayısı {result}";
                    GridYenile();
                }
                else
                {
                    lblresult.ForeColor = System.Drawing.Color.Red;
                    lblresult.Text = "komut işlendi ancak bir sonuç dönmedi";
                }
            }
            else
            {
                lblresult.ForeColor = System.Drawing.Color.Red;
                lblresult.Text = "Bağlantı Açılamadı.";
            }
        }

        public void GridYenile()
        {
            GridView1.DataSource = MusteriTelefonlariniGetir();
            GridView1.DataBind();
        }
        public DataTable MusteriTelefonlariniGetir()
        {
            var baglantiSorgusu = ConfigurationManager.ConnectionStrings["AdventureWorks2019ConnectionString"].ToString();
            var baglanti = new SqlConnection(baglantiSorgusu);
            baglanti.Open();
            if(baglanti.State == ConnectionState.Open)
            {
                var komut = new SqlCommand("select * from Person.PersonPhone where BusinessEntityID in (1,2,3,4,5)", baglanti);
                var adaptor = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adaptor.Fill(ds);
                return ds.Tables[0];
            }
            return null;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                ddKisi.SelectedValue = GridView1.Rows[index].Cells[0].Text;
                txtel.Text = GridView1.Rows[index].Cells[1].Text;
                DropDownList1.SelectedValue = GridView1.Rows[index].Cells[2].Text;
            }
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            string tel = txtel.Text.Trim();
            int kisi = Convert.ToInt32(ddKisi.SelectedValue);
            int telefonTipi = Convert.ToInt32(DropDownList1.SelectedValue);
            var dt = TabloGetir($"select phoneNumber from Person.PersonPhone where BusinessEntityID = {kisi} and PhoneNumber = '{tel}' and PhoneNumberTypeID = {telefonTipi}");
            if(dt==null || dt.Rows.Count == 0)
            {
                lblresult.ForeColor = System.Drawing.Color.Red;
                lblresult.Text = "Silinecek kayıt bulunamadı.";
            }
            else
            {
                var baglantiSorgusu = ConfigurationManager.ConnectionStrings["AdventureWorks2019ConnectionString"].ToString();
                var baglanti = new SqlConnection(baglantiSorgusu);
                baglanti.Open();
                if (baglanti.State == ConnectionState.Open)
                {
                    var komut = new SqlCommand($"delete from Person.PersonPhone where BusinessEntityID = {kisi} and PhoneNumber = '{tel}' and PhoneNumberTypeID = {telefonTipi}", baglanti);
                    int result = komut.ExecuteNonQuery();
                    if(result > 0)
                    {
                        lblresult.ForeColor = System.Drawing.Color.Green;
                        lblresult.Text = $"İşlem başarılı. Kayıt silindi.";
                        GridYenile();
                    }
                }
            }
        }

        public DataTable TabloGetir(string sorgu)
        {
            var baglantiSorgusu = ConfigurationManager.ConnectionStrings["AdventureWorks2019ConnectionString"].ToString();
            var baglanti = new SqlConnection(baglantiSorgusu);
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                var komut = new SqlCommand(sorgu, baglanti);
                var adaptor = new SqlDataAdapter(komut);
                DataSet ds = new DataSet();
                adaptor.Fill(ds);
                return ds.Tables[0];
            }
            return null;
        }
    }
}