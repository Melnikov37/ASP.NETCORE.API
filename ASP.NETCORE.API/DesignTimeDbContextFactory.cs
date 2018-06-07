using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ASP.NETCORE.API.Models;

namespace ASP.NETCORE.API
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TravelAgencyDataBaseContext>
    {
        public TravelAgencyDataBaseContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<TravelAgencyDataBaseContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new TravelAgencyDataBaseContext(builder.Options);
        }
    }
}

