using Microsoft.EntityFrameworkCore;
using Dominios;

namespace Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        public DbSet<Pessoa> pessoa { get; set; }

    }
}
