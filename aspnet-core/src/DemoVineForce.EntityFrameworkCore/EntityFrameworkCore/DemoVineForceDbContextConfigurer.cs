using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DemoVineForce.EntityFrameworkCore
{
    public static class DemoVineForceDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DemoVineForceDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DemoVineForceDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
