using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KutuphaneCodeFirst.Entities;
using KutuphaneCodeFirst.MockData;
using KutuphaneCodeFirst.ViewModels;
// ReSharper disable TooManyDeclarations

namespace KutuphaneCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, System.EventArgs e)
        {
             
        }
        private KitapIslemleri _frmKitapIslemleri;
        private CalisanIslemleri _frmCalisanIslemleri;
        private UyeIslemleri _frmUyeIslemleri;
        private KiralamaIslemleri _frmKiralamaIslemleri;
        private YazarIslemleri _frmYazarIslemleri;
        private void kitapİslemleriToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmKitapIslemleri == null || _frmKitapIslemleri.IsDisposed)
            {
                _frmKitapIslemleri = new KitapIslemleri
                {
                    MdiParent = this
                };
                _frmKitapIslemleri.WindowState = FormWindowState.Maximized;
                _frmKitapIslemleri.Show();
                
            }
        }

        private void calisanİslemleriToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmCalisanIslemleri == null || _frmCalisanIslemleri.IsDisposed)
            {
                _frmCalisanIslemleri = new CalisanIslemleri()
                {
                    MdiParent = this
                };
                _frmCalisanIslemleri.WindowState = FormWindowState.Maximized;
                _frmCalisanIslemleri.Show();
            }
        }

        private void uyeİslemleriToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmUyeIslemleri == null || _frmUyeIslemleri.IsDisposed)
            {
                _frmUyeIslemleri = new UyeIslemleri()
                {
                    MdiParent = this
                };
                _frmUyeIslemleri.WindowState = FormWindowState.Maximized;
                _frmUyeIslemleri.Show();
            }
        }

        private void kiralamaİslemleriToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmKiralamaIslemleri == null || _frmKiralamaIslemleri.IsDisposed)
            {
                _frmKiralamaIslemleri = new KiralamaIslemleri()
                {
                    MdiParent = this
                };
                _frmKiralamaIslemleri.WindowState = FormWindowState.Maximized;
                _frmKiralamaIslemleri.Show();
            }
        }

        private void yazarİslemleriToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (_frmYazarIslemleri == null || _frmYazarIslemleri.IsDisposed)
            {
                _frmYazarIslemleri = new YazarIslemleri()
                {
                    MdiParent = this
                };
                _frmYazarIslemleri.WindowState = FormWindowState.Maximized;
                _frmYazarIslemleri.Show();
            }
        }
        
    }
}
