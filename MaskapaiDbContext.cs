using Microsoft.EntityFrameworkCore;


namespace MaskapaiAPI
{
    public class MaskapaiDbContext : DbContext
    {

        public MaskapaiDbContext(DbContextOptions<MaskapaiDbContext> options) : base(options)
        {
        }

        public DbSet<Maskapai> Maskapais { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Maskapai>().ToTable("Maskapai", schema: "dbo");
        }

    }
}
