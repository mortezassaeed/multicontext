using Bogus;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class PromoveDbContext : DbContext
{
    public DbSet<Agent> Agents { get; set; }
    public DbSet<TransportUnit> TransportUnits { get; set; }
    public DbSet<Terminal> Terminals { get; set; }
    public DbSet<Customer> Customers { get; set; }


    public PromoveDbContext(DbContextOptions<PromoveDbContext> options) : base(options)
    {

    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>();
    }

}