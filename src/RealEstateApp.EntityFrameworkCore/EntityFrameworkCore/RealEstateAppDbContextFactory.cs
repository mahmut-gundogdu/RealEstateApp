using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RealEstateApp.Configuration;
using RealEstateApp.Web;

namespace RealEstateApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RealEstateAppDbContextFactory : IDesignTimeDbContextFactory<RealEstateAppDbContext>
    {
        public RealEstateAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RealEstateAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RealEstateAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RealEstateAppConsts.ConnectionStringName));

            return new RealEstateAppDbContext(builder.Options);
        }
    }
}
