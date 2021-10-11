using System.Data.Entity;

namespace CircleAreaCalculator
{
        public class CircleDbContext : DbContext
        {
            public CircleDbContext() : base("DBConnection") { }
            public DbSet<Circle> Circles { get; set; }
        }
}
