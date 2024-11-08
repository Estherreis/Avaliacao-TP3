using AvaliacaoA1.Data;
using AvaliacaoA1.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebPWrecover.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<AvaliacaoA1Context>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AvaliacaoA1Context>();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<AvaliacaoA1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AvaliacaoA1Context") ?? throw new InvalidOperationException("Connection string 'AvaliacaoA1Context' not found.")));
builder.Services.AddDbContext<AvaliacaoA1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AvaliacaoA1DbContext") ?? throw new InvalidOperationException("Connection string 'AvaliacaoA1Context' not found.")));

builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.Configure<AuthMessageSenderOptions>(
    builder.Configuration.GetSection("AuthMessageSenderOptions"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
