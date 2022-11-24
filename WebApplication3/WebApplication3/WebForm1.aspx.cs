using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ornGridView.DataSource = OrnekListesiGetir();
            ornGridView.DataBind();
        }

        public List<Ornek> OrnekListesiGetir()
        {
            var ornekler = new List<Ornek>();
            ornekler.Add(new Ornek("Emirhan", "Aykan", "Adana", "Elektrik-Elektronik"));
            ornekler.Add(new Ornek("aaa", "Aykan", "Adana", "Elektrik-Elektronik"));
            ornekler.Add(new Ornek("bbb", "Aykan", "Adana", "Elektrik-Elektronik"));
            ornekler.Add(new Ornek("ccc", "Aykan", "Adana", "Elektrik-Elektronik"));
            ornekler.Add(new Ornek("ddd", "Aykan", "Adana", "Elektrik-Elektronik"));
            ornekler.Add(new Ornek("eee", "Aykan", "Adana", "Elektrik-Elektronik"));
            ornekler.Add(new Ornek("fff", "Aykan", "Adana", "Elektrik-Elektronik"));
            return ornekler;
        }

        protected void ornGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ornGridView.PageIndex = e.NewPageIndex;
            ornGridView.DataSource = OrnekListesiGetir();
            ornGridView.DataBind();
        }
    }

    public class Ornek
    {
        public Ornek(string AD, string SOYAD, string ADRES, string BOLUM)
        {
            this.AD = AD;
            this.SOYAD = SOYAD;
            this.ADRES = ADRES;
            this.BOLUM = BOLUM;
        }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string BOLUM { get; set; }
        public string ADRES { get; set; }
    }
}