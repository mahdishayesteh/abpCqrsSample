using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace abpcqrstest.EntityFrameworkCore;

public static class abpcqrstestDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<abpcqrstestDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<abpcqrstestDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}
