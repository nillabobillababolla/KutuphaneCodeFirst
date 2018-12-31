namespace KutuphaneCodeFirst.ViewModels
{
    public class KitapViewModel
    {
        public int KitapId { get; set; }
        public int YazarId { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public string Kategori { get; set; }
        public int Adet { get; set; }

        public override string ToString() => $"{KitapAdi}  ----  {YazarAdi} {YazarSoyadi}";
    }
}
