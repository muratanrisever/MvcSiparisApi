using Microsoft.AspNetCore.Mvc;
using MvcSiparisApi.Api.Data;
using MvcSiparisApi.Api.Models;

namespace MvcSiparisApi.Api.Controllers
{
    public class SiparisController : ControllerBase
    {
        private readonly SiparisDbContext _context;

        public SiparisController(SiparisDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("api/siparisEkle")]
        public IActionResult SiparisEkle([FromBody] Models.Siparis model)
        {
            _context.Siparisler.Add(model);
            _context.SaveChanges();
            return Ok(model);
        }
        [HttpGet]
        [Route("api/tumSiparisler")]
        public IActionResult TumSiparisler()
        {
            var siparisList = _context.Siparisler.ToList();
            return Ok(siparisList);
        }
    }
}