using Microsoft.EntityFrameworkCore;
using RestApi.Model;

namespace RestApi.Context
{
    public class Context_DB : DbContext
    {
        public Context_DB(DbContextOptions<Context_DB> options) : base(options)
        {

        }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
