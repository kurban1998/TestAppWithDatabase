using System.Data.Entity;

namespace CircleAreaCalculator
{
        public class FiguresDbContext : DbContext
        {
            /// <summary>
            /// База данных фигур
            /// </summary>
            public FiguresDbContext() : base("DBConnection") { }
            /// <summary>
            /// Таблица окружностей
            /// </summary>
            public DbSet<Circle> Circles { get; set; }
            /// <summary>
            /// Таблица трапеций
            /// </summary>
            public DbSet<Trapeze> Trapezes { get; set; }
        }
}
