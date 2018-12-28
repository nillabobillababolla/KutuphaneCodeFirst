namespace KutuphaneCodeFirst.ViewModels
{
    public class KitapViewModel
    {
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string Kategori { get; set; }
        public override string ToString() => $"{KitapAdi}-/{YazarAdi}-/{Kategori}";
    }
}
