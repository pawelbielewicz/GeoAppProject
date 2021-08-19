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

        public DbSet<GeoObject> GeoObjects { get; set; }

        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
