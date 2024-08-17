using Microsoft.EntityFrameworkCore;
using Habitr.src.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

// Configure DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
	options.UseMySql(
		builder.Configuration.GetConnectionString("DefaultConnection"), 
		new MySqlServerVersion(new Version(8, 0, 21))
	);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
	c.SwaggerEndpoint("/swagger/v1/swagger.json", "Habitr API V1");
	c.RoutePrefix = string.Empty;
});
app.UseRouting();
app.MapControllers();
app.UseHttpsRedirection();

app.Run();
