using System.Data.Entity;

namespace CircleAreaCalculatorNew
{
        public class CircleDbContext : DbContext
        {
            public CircleDbContext() : base("DBConnection") { }
            public DbSet<Circle> Circles { get; set; }
        }
}
