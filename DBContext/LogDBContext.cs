using Microsoft.EntityFrameworkCore;

namespace MultiDataBase.CRUD;

public class LogDBContext : DbContext
{
    public DbSet<Logs> Logs {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("MyLogDB");
    }
}
