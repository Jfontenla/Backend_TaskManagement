using Microsoft.EntityFrameworkCore;
using TaskManagementApp.Domain.Entities;

namespace TaskManagementApp.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Domain.Entities.Task> Tasks { get; set; }
    public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<CompletedState> CompletedStates { get; set; }
    public DbSet<OpenState> OpenStates { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
