using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneCodeFirst.Entities
{
    [Table("Kitaplar")]
   public class Kitap
    {
        [Key]
        public int KitapId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Kitap adi en fazla 100 karakter olabilir.")]
        public string KitapAdi { get; set; }
        public int YazarId { get; set; }
        [ForeignKey("YazarId")]
        public Yazar Yazar { get; set; }
    }
}
