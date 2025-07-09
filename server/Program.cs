var builder = WebApplication.CreateBuilder(args);

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

builder.Services.AddControllers();

var app = builder.Build();
app.UseCors("AllowReactDev");
app.MapControllers();

app.Run();
