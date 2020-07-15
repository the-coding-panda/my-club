using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyClub.EntityFrameworkCore
{
    public static class MyClubDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyClubDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyClubDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
