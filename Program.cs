using Npgsql;
using Microsoft.EntityFrameworkCore;
using dotSkog.Data;

var builder = WebApplication.CreateBuilder(args);


// Database Configuration (Entity Framework Core)
builder.Services.AddDbContext<MyDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Database Initialization (optional, but recommended)
using (var scope = app.Services.CreateScope()) // <-- Add this using block
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<MyDbContext>();

    try
    {
        context.Database.Migrate(); // Use Migrate instead of EnsureCreated for production
    }
    catch (NpgsqlException ex)
    {
        // Log the exception (use a proper logger in production)
        Console.WriteLine("An error occurred while creating/migrating the database: " + ex.Message);
        throw; // Rethrow the exception to stop the application
    }
}




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();