using Microsoft.EntityFrameworkCore;

namespace WebAPICoreEntity.Model
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

       public DbSet<Students> Students { get; set; } 
    }
}
