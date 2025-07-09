// Create web app builder
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Register CORS to allow requests from the React app
builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowReactDev",
            builder =>
            {
                builder.WithOrigins("http://localhost:5173")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
            }
        );
    }
);

// Add controller support
builder.Services.AddControllers();

// Build the app
WebApplication app = builder.Build();

// Activate CORS
app.UseCors("AllowReactDev");

// Map the controller endpoints to HTTP routes
app.MapControllers();

// Start the server
app.Run();