namespace MvcSiparisApi.Web.Models
{
    public class SiparisViewModel
    {
        public string MusteriAdi { get; set; }
        public string UrunAdi { get; set; }
        public int Adet { get; set; }
        public DateTime SiparisTarihi { get; set; } = DateTime.Now;
    }
}
