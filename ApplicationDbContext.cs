using System;
using System.Threading.Tasks;

namespace new3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<new3.Data.GED> GED { get; set; }
        public DbSet<new3.Data.Mentor> Mentor { get; set; }

        internal object Attach(Mentor mentor)
        {
            throw new NotImplementedException();
        }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}