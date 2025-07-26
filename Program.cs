using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using POsWebAPITesting.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// By Abdul R
builder.Services.AddDbContext<PurchaseSalesAndOrdersdbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("constring")));
// End 
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSwaggerGen(options =>
//{
//    options.SwaggerDoc("v1", new OpenApiInfo
//    {
//        Version = "v1",
//        Title = "ToDo API",
//        Description = "An ASP.NET Core Web API for managing ToDo items",
//        TermsOfService = new Uri("https://localhost:7092/"),
//        Contact = new OpenApiContact
//        {
//            Name = "Example Contact",
//            Url = new Uri("https://localhost:7092/")
//        },
//        License = new OpenApiLicense
//        {
//            Name = "Example License",
//            Url = new Uri("https://localhost:7092/license")
//        }
//    });
//    // using System.Reflection;
//    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
//    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
//});

var app = builder.Build();

app.UseCors(builder => builder
    .WithOrigins("*")           // Allow requests from any origin (wildcard)
    .AllowAnyHeader()           // Allow any HTTP headers (e.g., Content-Type, Authorization)
    .AllowAnyMethod());         // Allow any HTTP methods (GET, POST, PUT, DELETE, etc.)


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsEnvironment("UnitTest"))
{
    app.MapOpenApi();
    //app.UseSwagger();
    app.UseSwagger(options =>
    {
        options.SerializeAsV2 = true;
    });
    app.UseSwaggerUI();
    //app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
    //{
    //    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    //    options.RoutePrefix = "5016"; // string.Empty;
    //});

}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
