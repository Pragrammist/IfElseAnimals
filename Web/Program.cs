using Microsoft.EntityFrameworkCore;
using Web.DbContexts;

var builder = WebApplication.CreateBuilder(args);
var dbCon = builder.Configuration.GetConnectionString("Sqlite");



// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<OverallContext>(opt => opt.UseSqlite(dbCon));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}

app.UseSwagger();
app.UseSwaggerUI(options => {
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

app.UseAuthorization();

app.MapControllers();

app.Run();
