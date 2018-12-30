using KutuphaneCodeFirst.Entities;
using KutuphaneCodeFirst.Helpers;
using KutuphaneCodeFirst.MockData;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KutuphaneCodeFirst
{
    public partial class KitapIslemleri : Form
    {
        private Kitap _seciliKitap = new Kitap();
        private Yazar _seciliYazar = new Yazar();

        public KitapIslemleri()
        {
            InitializeComponent();
        }
        private void KitapIslemleri_Load(object sender, EventArgs e)
        {
            cmbYazar.DataSource = Mock.Yazarlar;
            lstKitaplar.DataSource = Mock.Kitaplar;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lstKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {
            _seciliKitap = (Kitap)lstKitaplar.SelectedItem;
            _seciliYazar = (Mock.Yazarlar.Where(o => o.YazarId == _seciliKitap.YazarId)).First();
               
            txtKitapAdi.Text = _seciliKitap.KitapAdi;
            txtKategori.Text = _seciliKitap.Kategori;
            cmbYazar.SelectedItem = _seciliYazar;
            txtAdet.Text = _seciliKitap.Adet.ToString();
        }

        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {

            var db = new MyContext();
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var yazar = cmbYazar.SelectedItem as Yazar;
                    if (yazar == null) return;

                    var query = (from k in db.Kitaplar
                        where k.KitapAdi == txtKitapAdi.Text
                        select k.Adet);
                   

                    if (query.First() > 0)
                    {
                        MessageBox.Show(@"Eklemeye calistiginiz kitap zaten var.");
                        tran.Rollback();
                    }
                    else
                    {
                        var kitap = new Kitap
                        {
                            KitapAdi = txtKitapAdi.Text,
                            Adet = Int32.Parse(txtAdet.Text),
                            Kategori = txtKategori.Text,
                            YazarId = yazar.YazarId,
                        };
                        var adet = KitapHelper.KitapEkle(kitap);
                        tran.Commit();
                        MessageBox.Show($@"{adet} adet Kitap eklendi.");
                    }
                   
                }
                catch (Exception exception)
                {
                    tran.Rollback();
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
