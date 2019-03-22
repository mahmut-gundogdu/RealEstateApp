using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RealEstateApp.EntityFrameworkCore
{
    public static class RealEstateAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RealEstateAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RealEstateAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
