using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LLMall.EntityFrameworkCore
{
    public static class LLMallDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LLMallDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LLMallDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}