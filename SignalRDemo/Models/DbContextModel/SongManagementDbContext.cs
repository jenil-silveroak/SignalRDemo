using Microsoft.EntityFrameworkCore;

namespace SignalRDemo.Models.DbContextModel
{
    public class SongManagementDbContext : DbContext
    {
        public SongManagementDbContext(DbContextOptions<SongManagementDbContext> options) : base(options) { }

        public DbSet<Singer> Singers { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SungBy> SungBys { get; set; }
    }
}
