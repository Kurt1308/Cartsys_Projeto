using Domain.Entity;
using Microsoft.EntityFrameworkCore;


namespace Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Pessoa> pessoa { get; set; }

    }
}
