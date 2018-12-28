using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneCodeFirst.Entities
{

    [Table("Yazarlar")]
   public class Yazar
    {
        [Key]
        public int YazarId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Yazarin adi en fazla 50 karakter olabilir.")]
        public string YazarAd { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Yazarin soyadi en fazla 50 karakter olabilir.")]
        public string YazarSoyad { get; set; }

        public virtual ICollection<Kitap> Kitaplar { get; set; } = new HashSet<Kitap>();
    }
}
