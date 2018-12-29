using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KutuphaneCodeFirst.Entities;
using KutuphaneCodeFirst.MockData;
using KutuphaneCodeFirst.ViewModels;

namespace KutuphaneCodeFirst
{ 
    public partial class KitapIslemleri : Form
    { 
        public KitapIslemleri()
        {
            InitializeComponent();
        }
        KitapViewModel seciliKitap = new KitapViewModel();

        private void KitapIslemleri_Load(object sender, EventArgs e)
        {
            lstKitaplar.DataSource = Form1.KitaplariGetir();
            cmbYazar.DataSource = Mock.Yazarlar;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
           seciliKitap = (KitapViewModel)lstKitaplar.SelectedItem;
           var seciliYazar = (from o in Mock.Yazarlar
                           where seciliKitap.YazarId == o.YazarId
                            select o) as Yazar;



            txtKitapAdi.Text = seciliKitap.KitapAdi;
            txtKategori.Text = seciliKitap.Kategori;
            cmbYazar.SelectedItem = seciliYazar;
            nuAdet.Value = seciliKitap.Adet;
        }
    }
}
