using Microsoft.EntityFrameworkCore;

namespace MongoDBEFCoreDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            builder.Services.AddControllers();

            var mongoDBSettings = builder.Configuration.GetSection("MongoDBSettings").Get<MongoDBSettings>();
            builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDBSettings"));

            builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseMongoDB(mongoDBSettings.AtlasURI ?? "", mongoDBSettings.DatabaseName ?? ""));
            builder.Services.AddScoped<MongDbService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();



            app.Run();
        }
    }
}
