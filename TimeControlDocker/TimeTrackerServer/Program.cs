using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");
app.UseRouting();

// Minimal API endpoints
app.MapGet("/", async context =>
{
    await context.Response.WriteAsync("Time Tracker API is running!");
});

app.MapGet("/api/productivity", async context =>
{
    var stats = new
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd"),
        WorkTime = new Random().Next(120, 360),
        BreakTime = new Random().Next(30, 120),
        EntertainmentTime = new Random().Next(60, 180),
        ActiveApplications = new[] { "Visual Studio", "Browser", "Word" },
        LastUpdated = DateTime.Now
    };

    context.Response.ContentType = "application/json";
    await context.Response.WriteAsync(JsonSerializer.Serialize(stats));
});

app.MapGet("/api/tasks", async context =>
{
    var tasks = new[]
    {
        new { Id = 1, Name = "Complete Docker assignment", Completed = true },
        new { Id = 2, Name = "Write client application", Completed = false },
        new { Id = 3, Name = "Test Docker Compose", Completed = false }
    };

    context.Response.ContentType = "application/json";
    await context.Response.WriteAsync(JsonSerializer.Serialize(tasks));
});

app.Run();

await Task.Delay(10000);

