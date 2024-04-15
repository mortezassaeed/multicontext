using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

var services = new ServiceCollection();

services.AddDbContext<PromoveDbContext>(
    options => options.UseSqlServer("Server=./;Database=MultiContextPromove;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True"));


//services.AddDbContext<OfferManagerDbContext>(
//options => options.UseSqlServer("Server=./;Database=MultiContextOfferManager;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True"));

var serviceProvider = services.BuildServiceProvider();


