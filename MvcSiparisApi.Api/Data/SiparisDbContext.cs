using Microsoft.EntityFrameworkCore;
using MvcSiparisApi.Api.Models;

namespace MvcSiparisApi.Api.Data
{
    public class SiparisDbContext : DbContext
    {
        public SiparisDbContext(DbContextOptions<SiparisDbContext> options) : base(options) {}
        public DbSet<Siparis> Siparisler { get; set; }
    }
}
