using BlazorApp1.Components;
using Bogus;
using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


builder.Services.AddDbContext<PromoveDbContext>(
options => options.UseSqlServer("Server=./;Database=MultiContextPromoveMain;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True"));


builder.Services.AddDbContext<OfferManagerDbContext>(
options => options.UseSqlServer("Server=./;Database=MultiContextOfferManagerMain;Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True"));


var app = builder.Build();


using (var context = builder.Services.BuildServiceProvider().GetRequiredService<PromoveDbContext>())
{
    var terminal = context.Set<Terminal>().FirstOrDefault(t => t.Id == 1);
    context.Remove(terminal!);
    context.SaveChanges();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
