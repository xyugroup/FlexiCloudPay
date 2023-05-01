using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using FlexiCoudPay.Configuration;
using FlexiCoudPay.Web;

namespace FlexiCoudPay.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FlexiCoudPayDbContextFactory : IDesignTimeDbContextFactory<FlexiCoudPayDbContext>
    {
        public FlexiCoudPayDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FlexiCoudPayDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            FlexiCoudPayDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FlexiCoudPayConsts.ConnectionStringName));

            return new FlexiCoudPayDbContext(builder.Options);
        }
    }
}
