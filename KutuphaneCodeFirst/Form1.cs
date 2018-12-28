using System.Windows.Forms;
using KutuphaneCodeFirst.MockData;

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
            lstYazarlar.DataSource = Mock.Yazarlar;
            lstKitaplar.DataSource = Mock.Kitaplar;
            lstCalisanlar.DataSource = Mock.Calisanlar;
        }
    }
}
