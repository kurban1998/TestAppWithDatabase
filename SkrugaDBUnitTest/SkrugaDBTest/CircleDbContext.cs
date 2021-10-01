
using System.Data.Entity;


namespace SkrugaDBTest
{
   public  class CircleDbContext : DbContext
    {
        public CircleDbContext() : base("DBConnection") { }
        public DbSet<Circle> Circles { get; set; }
    }
}
