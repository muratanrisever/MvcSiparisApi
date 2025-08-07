using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcSiparisApi.Api.Models
{
    [Table("Siparisler")]
    public class Siparis
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MusteriAdi { get; set; }
        [Required]
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public DateTime SiparisTarihi { get; set; } = DateTime.Now;
    }
}
