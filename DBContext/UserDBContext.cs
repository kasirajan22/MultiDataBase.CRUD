using Microsoft.EntityFrameworkCore;

namespace MultiDataBase.CRUD;

public class UserDBContext : DbContext
{
    public DbSet<Users> Users{ get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("MyDatabase");
    }
}
