using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneCodeFirst.Entities
{
    [Table("Kiralayanlar")]
   public class Kiralayan
    {
        [Key]
        public int KiralayanId { get; set; }

        [StringLength(11, ErrorMessage = "Tckn 11 haneli olmalidir.")]
        [Index("IX_Tckn", IsUnique = true)]
        [Required]
        public string Tckn { get; set; }

        [StringLength(50,ErrorMessage = "Ad en fazla 50 karakter olabilir.")]
        public string KiralayanAd { get; set; }


        [StringLength(200,ErrorMessage = "Adres en fazla 200 karakter olabilir.")]
        public string Adres { get; set; }

        public DateTime KayıtTarihi { get; set; } = DateTime.Now;
    }
}
