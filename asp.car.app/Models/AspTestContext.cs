using Microsoft.EntityFrameworkCore;

namespace asp.car.app.Models
{
    public class AspTestContext : DbContext
    {
        public AspTestContext(DbContextOptions<AspTestContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Make> Makes { get; set; }
    }
}