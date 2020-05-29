using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace JoshTheGent.EntityFrameworkCore
{
    public static class JoshTheGentDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<JoshTheGentDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<JoshTheGentDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
