using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneCodeFirst.Entities
{
    [Table("Kiralar")]
   public class Kira
    {
        [Key, Column(Order = 0)]
        public int KitapId { get; set; }

        [Key, Column(Order = 1)]
        public int KiralayanId { get; set; }
        public DateTime KiralamaTarihi { get; set; }



        [ForeignKey("KitapId")]
        public virtual Kitap Kitap { get; set; }

        [ForeignKey("KiralayanId")]
        public virtual Kiralayan Kiralayan { get; set; }
    }
}
