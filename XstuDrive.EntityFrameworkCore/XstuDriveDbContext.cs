using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XstuDrive.Domain.Base;

namespace XstuDrive.EntityFrameworkCore
{
    public class XstuDriveDbContext : DbContext
    {
        public DbSet<UserInfo> UserInfo { get; set; }
        public XstuDriveDbContext(DbContextOptions<XstuDriveDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
