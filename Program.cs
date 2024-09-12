var builder = WebApplication.CreateBuilder(args);

// Create and configure the Startup class
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services); // Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.
startup.Configure(app, app.Environment);

app.Run();
