using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoursquareApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FourTool ftool = new FourTool();
        public List<Four.Venue> Firmalar { get; set; }
        private void btnGetir_Click(object sender, EventArgs e)
        {
            Firmalar = ftool.FirmalariGetir();
            ListeyiDoldur(Firmalar);
            lstFirmlar.DisplayMember = "name";
            lstFirmlar.ValueMember = "id";
        }

        private void ListeyiDoldur(List<Four.Venue> firmalar)
        {
            lstFirmlar.Items.Clear();
            var sirali = firmalar.OrderBy(x => x.name).ToList();
            sirali.ForEach(x => lstFirmlar.Items.Add(x));
        }
        public Four.Venue SeciliFirma { get; set; }
        private void lstFirmlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblKategori.Text = "";
            if (lstFirmlar.SelectedItem == null) return;
            SeciliFirma = lstFirmlar.SelectedItem as Four.Venue;

            lblAdres.Text = SeciliFirma.location.address;
            lblFirmaAdi.Text = SeciliFirma.name;
            lblHereNow.Text = SeciliFirma.hereNow.summary;

            if (SeciliFirma.categories.Count > 0)
                SeciliFirma.categories.ForEach(x => lblKategori.Text += "\n" + x.name);
            else
                lblKategori.Text = "Kategori Yok";
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string kelime = txtArama.Text.ToLower();
            var sonuc = Firmalar.Where(x => x.name.ToLower().Contains(kelime)).ToList();
            ListeyiDoldur(sonuc);
        }
        //https://maps.google.com/maps?q=41.0442219,29.0071594
        private void btnHaritadaGoster_Click(object sender, EventArgs e)
        {
            if (SeciliFirma == null) return;

            string lat = SeciliFirma.location.lat.ToString().Replace(",", ".");
            string lng = SeciliFirma.location.lng.ToString().Replace(",", ".");
            string mapUrl = $"https://maps.google.com/maps?q={lat},{lng}";
            webBrowser1.Url = new Uri(mapUrl);
            if (MessageBox.Show("Tarayıcıda gösterilsin mi?", "Cevap ver!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Process.Start(mapUrl);
        }
    }
}