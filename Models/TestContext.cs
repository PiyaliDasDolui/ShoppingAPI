using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

public class TestContext: DbContext
{
    public TestContext(DbContextOptions<TestContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set;} = null!;
}