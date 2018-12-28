using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneCodeFirst.Entities
{
    [Table("Calisanlar")]
   public class Calisan
    {
        [Key]
        public int CalisanId { get; set; }
        
        [Required]
        [StringLength(50, ErrorMessage = "Calisan adi en fazla 50 karakter olabilir.")]
        public string CalisanAd { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Calisan soyadi en fazla 50 karakter olabilir.")]
        public string CalisanSoyad { get; set; }

        [StringLength(20,ErrorMessage = "Gorev en fazla 20 karakter olabilir.")]
        public string Gorev { get; set; }

        public decimal Maas { get; set; }

        public override string ToString() => $"{CalisanAd} {CalisanSoyad}";

    }
}
