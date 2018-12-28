namespace KutuphaneCodeFirst.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Yazarlar")]
   public class Yazar
    {
        [Key]
        public int YazarId { get; set; }
        [StringLength(100, ErrorMessage = "Yazarin adi 100 karakterden fazla olamaz.")]
        public string YazarAd { get; set; }
        [StringLength(100, ErrorMessage = "Yazarin soyadi 100 karakterden fazla olamaz.")]
        public string YazarSoyad { get; set; }
    }
}
