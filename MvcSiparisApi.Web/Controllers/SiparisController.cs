using Microsoft.AspNetCore.Mvc;
using MvcSiparisApi.Web.Models;

namespace MvcSiparisApi.Web.Controllers
{
    [Route("[controller]/[action]")]
    public class SiparisController : Controller
    {
        private readonly HttpClient _httpClient;
        public SiparisController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7283/");
        }
        public IActionResult Yeni()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Yeni(SiparisViewModel model)
        {
            var response = await _httpClient.PostAsJsonAsync("api/siparisEkle", model);
            if (response.IsSuccessStatusCode)
            {
                ViewBag.Mesaj = "Sipariş başarıyla alındı.";
            }
            else
            {
                ViewBag.Mesaj = "Sipariş alınırken bir hata oluştu 😢";
            }

            return View();
        }
        public async Task<IActionResult> Liste()
        {
            var response = await _httpClient.GetAsync("api/tumSiparisler");

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadFromJsonAsync<List<SiparisViewModel>>();
                return View(data);
            }

            ViewBag.Mesaj = "Siparişler alınamadı 😢";
            return View(new List<SiparisViewModel>());
        }
    }
}
