using System.Data.Entity;

namespace BoostNetwork.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<DataContext>(null);
        }

        // DbSet's here
        // public DbSet<Lesson> Lessons { get; set; }
    }
}
