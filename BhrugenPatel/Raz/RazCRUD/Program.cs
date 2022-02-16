using Microsoft.EntityFrameworkCore;
using RazCRUD.Data;
// with dotnet command can pass custom args here
// creates web application builder object

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// DI inserted here, before .Build() call

// we are just adding  items to the container, so that we can extract and use with the help of dependency injection
// we are saying that for this DB context for database, we want to use SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    //extract our connection string from App Settings
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//app.UseAuthentication(); 
app.UseAuthorization();

// maps the url request to the corresponding page in the pages folder
app.MapRazorPages();

app.Run();
