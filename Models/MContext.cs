using Microsoft.EntityFrameworkCore;

namespace InMemory.Models
{
    public class MContext : DbContext
    {
        public MContext(DbContextOptions<MContext> options) : base(options) {
            
        }
        public DbSet<Modell> model { get; set; }

    }
}