using Microsoft.EntityFrameworkCore;

namespace RestWithASPNET10Ed.Model.Context
{
    public class MSSQLContext : DbContext
    {
        public MSSQLContext(DbContextOptions<MSSQLContext> options) 
            : base(options) {}

        public DbSet<Person> Persons { get; set; }
    }
}
