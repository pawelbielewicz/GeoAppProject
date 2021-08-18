using GeoApp.Model;
using Microsoft.EntityFrameworkCore;

namespace GeoApp.Data
{
    public class GeoObjectDbContext: DbContext
    {
        public GeoObjectDbContext(DbContextOptions<GeoObjectDbContext> options) : base(options)
        {
        }

        public GeoObjectDbContext()
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=.;Initial Catalog=Geo;Persist Security Info=False;User ID=sa;Password=LocalPassword1234;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;");

        public DbSet<GeoObject> GeoObjects { get; set; }

        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
