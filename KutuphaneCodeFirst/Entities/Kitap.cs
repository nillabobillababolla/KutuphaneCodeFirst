using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
// ReSharper disable ClassNeverInstantiated.Global

namespace KutuphaneCodeFirst.Entities
{
    [Table("Kitaplar")]
    public class Kitap
    {
        [Key]
        public int KitapId { get; set; }

        [Index("IX_KitapAdi",IsUnique = true)]
        [Required]
        [StringLength(50, ErrorMessage = "Kitap adi en fazla 50 karakter olabilir.")]
        public string KitapAdi { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Kategori adi en fazla 50 karakter olabilir.")]
        public string Kategori { get; set; }

        public int Adet { get; set; }

        public int YazarId { get; set; }

        [ForeignKey("YazarId")]
        public Yazar Yazar { get; set; }

        public override string ToString() => $"{KitapAdi}";

        public virtual ICollection<Kira> Kiralar { get; set; } = new HashSet<Kira>();
    }
}
