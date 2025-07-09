// Create web app builder
using Elastic.Clients.Elasticsearch;
using Elastic.Clients.Elasticsearch.Security;
using Elastic.Transport;
using Microsoft.AspNetCore.Http.Connections;

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

// Grab Elastic connection settings from configuration
var uri = builder.Configuration["Elasticsearch:Uri"];
var apiKey = builder.Configuration["Elasticsearch:ApiKey"];

// Configure Elasticsearch client with API key authentication
var elasticSettings = new ElasticsearchClientSettings(new Uri(uri))
    .Authentication(new Elastic.Transport.ApiKey(apiKey));

// Create the Elasticsearch instance with the configured settings
var elastic = new ElasticsearchClient(elasticSettings);

// Register the Elasticsearch client for dependency injection
builder.Services.AddSingleton<ElasticsearchClient>(elastic);

// Build the app
WebApplication app = builder.Build();

// Activate CORS
app.UseCors("AllowReactDev");

// Map the controller endpoints to HTTP routes
app.MapControllers();

// Start the server
app.Run();