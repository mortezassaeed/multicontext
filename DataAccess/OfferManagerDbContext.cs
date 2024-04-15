using Bogus;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class OfferManagerDbContext : DbContext
{
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<OfferService> OfferService { get; set; }


    public OfferManagerDbContext(DbContextOptions<OfferManagerDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Supplier>().HasData(SupplierSeed().ToList());
        //modelBuilder.Entity<OfferService>().HasData(OfferServicesSeed().ToList());
    }

    //IEnumerable<Supplier> SupplierSeed()
    //{
    //    var faker = new Faker("en");
    //    for (int i = 0; i < 100; i++)
    //    {
    //        yield return new Faker<Supplier>()
    //        .RuleFor(m => m.Id, (f, a) => a.Id = (int)f.Random.UInt())
    //        .RuleFor(m => m.Name, (f, m) => m.Name = f.Person.FirstName)
    //        .RuleFor(m => m.LastName, (f, m) => m.LastName = null);
    //    }
    //}


    //IEnumerable<OfferService> OfferServicesSeed()
    //{
    //    var faker = new Faker("en");
    //    for (int i = 0; i < 100; i++)
    //    {
    //        yield return new Faker<OfferService>()
    //            .RuleFor(m => m.Id, (f, a) => a.Id = (int)f.Random.UInt())
    //            .RuleFor(m => m.Quantity, (f, m) => m.Quantity = f.Random.Int())
    //            .RuleFor(m => m.Target, (f, m) => m.Target = f.Random.Decimal())
    //            .RuleFor(m => m.IndividualMargin, (f, m) => m.IndividualMargin = f.Random.Decimal())
    //            .RuleFor(m => m.Price, (f, m) => m.Price = f.Random.Decimal());
    //    }
    //}

}

