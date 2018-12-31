using System;

namespace KutuphaneCodeFirst.ViewModels
{
   public class KiraViewModel
    {
        public int KitapId { get; set; }
        public int KiralayanId { get; set; }
        public string KitapAdi { get; set; }
        public string KiralayanAdi { get; set; }
        public string KiralayanSoyad { get; set; }
        public DateTime KiralamaTarihi { get; set; }

        public override string ToString() => $@"{KitapAdi}  -  {KiralayanAdi} {KiralayanSoyad}  /  {KiralamaTarihi}";
    }
}
