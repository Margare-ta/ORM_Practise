using Microsoft.EntityFrameworkCore;

namespace Songs;
internal partial class DatabaseContext : DbContext
{
    public DbSet<Song> Songs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("server=localhost;database=Songs;user=root;");
    }
}

