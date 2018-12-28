using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneCodeFirst.Entities
{
    [Table("Kiralar")]
   public class Kira
    {
        [Key]
        public int KiraId { get; set; }

        [Required]
        public int KitapId { get; set; }

        [Required]
        public int KiralayanId { get; set; }

        public DateTime KiralamaTarihi { get; set; }

        [ForeignKey("KiralayanId")]
        public virtual Kiralayan Kiralayan { get; set; }

        [ForeignKey("KitapId")]
        public virtual Kitap Kitap { get; set; }

    }
}
