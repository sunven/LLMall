using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LLMall.EntityFrameworkCore
{
    public static class LLMallDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LLMallDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LLMallDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
