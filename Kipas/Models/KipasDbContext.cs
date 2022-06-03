using Microsoft.EntityFrameworkCore;
namespace Kipas.Models
{
    public partial class KipasDbContext : DbContext
    {
        public KipasDbContext()
        {

        }
        public KipasDbContext(DbContextOptions<KipasDbContext> options)
         : base(options)
        {
        }
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Initial Catalog=Db_Kipas;MultipleActiveResultSets=true;Trusted_Connection=True;");

            }
        }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<State> State { get; set; }
       
    }
}
