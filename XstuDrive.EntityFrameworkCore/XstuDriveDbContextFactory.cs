using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace XstuDrive.EntityFrameworkCore
{
    internal class XstuDriveDbContextFactory : IDesignTimeDbContextFactory<XstuDriveDbContext>
    {
        public XstuDriveDbContext CreateDbContext(string[] args)
        {
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json").Build();

            var optionsBuilder = new DbContextOptionsBuilder<XstuDriveDbContext>();
            //optionsBuilder.UseMySql(builder.GetConnectionString("MySqlConnectionStr"), ServerVersion.Parse("5.7"));
            optionsBuilder.UseMySql("server=localhost;database=xstudrive_business;uid=root;pwd=xiongjie520", ServerVersion.Parse("5.7"));
            return new XstuDriveDbContext(optionsBuilder.Options);
        }
    }
}
