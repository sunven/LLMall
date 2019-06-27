using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LLMall.Configuration;
using LLMall.Web;

namespace LLMall.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LLMallDbContextFactory : IDesignTimeDbContextFactory<LLMallDbContext>
    {
        public LLMallDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LLMallDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LLMallDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LLMallConsts.ConnectionStringName));

            return new LLMallDbContext(builder.Options);
        }
    }
}
