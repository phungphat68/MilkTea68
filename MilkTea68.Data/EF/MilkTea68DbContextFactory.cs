using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MilkTea68.Data.EF
{
    public class MilkTea68DbContextFactory : IDesignTimeDbContextFactory<MilkTea68DbContext>
    {
        public MilkTea68DbContext CreateDbContext(string[] args)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("MilkTea68Db");

            var optionsBuilder = new DbContextOptionsBuilder<MilkTea68DbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MilkTea68DbContext(optionsBuilder.Options);
        }
    }
}
