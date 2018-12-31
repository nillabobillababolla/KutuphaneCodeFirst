using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using KutuphaneCodeFirst.BLL;
using KutuphaneCodeFirst.Entities;

namespace KutuphaneCodeFirst
{
    public partial class CalisanIslemleri : Form
    {
        public CalisanIslemleri()
        {
            InitializeComponent();
        }

        private void CalisanIslemleri_Load(object sender, System.EventArgs e)
        {
            ListeDoldur();
        }

        private void ListeDoldur()
        {
            try
            {
                var db = new MyContext();
                lstCalisanlar.DataSource = db.Calisanlar.OrderBy(x => x.CalisanAd).ThenBy(y => y.CalisanSoyad).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstCalisanlar_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CalisanAyrintiGetir();
        }

        private void CalisanAyrintiGetir()
        {
            var db = new MyContext();
            if (lstCalisanlar.SelectedItem == null) return;

            var seciliCalisan = lstCalisanlar.SelectedItem as Calisan;
            txtCalisanAdi.Text = seciliCalisan?.CalisanAd;
            txtCalisanSoyad.Text = seciliCalisan?.CalisanSoyad;
            txtMaas.Text = seciliCalisan?.Maas.ToString(CultureInfo.InvariantCulture);
            txtGorev.Text = seciliCalisan?.Gorev;
        }

        private void btnCalisanKaydet_Click(object sender, EventArgs e)
        {
            var calisan = new Calisan()
            {
                CalisanAd = txtCalisanAdi.Text,
                CalisanSoyad = txtCalisanSoyad.Text,
                Gorev = txtGorev.Text,
                Maas = decimal.Parse(txtMaas.Text)
            };

            if (CalisanBusiness.CalisanEkle(calisan) > 0)
            {
                MessageBox.Show($@"{calisan} kaydedildi.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var db = new MyContext();
            if (lstCalisanlar.SelectedItem == null) return;
            var seciliCalisan = lstCalisanlar.SelectedItem as Calisan;

            var calisan = new Calisan()
            {
                CalisanAd = txtCalisanAdi.Text,
                CalisanSoyad = txtCalisanSoyad.Text,
                Gorev = txtGorev.Text,
                Maas = decimal.Parse(txtMaas.Text)
            };
            CalisanBusiness.CalisanGuncelle(calisan,seciliCalisan);
        }
    }
}
