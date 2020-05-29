using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using JoshTheGent.Configuration;
using JoshTheGent.Web;

namespace JoshTheGent.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class JoshTheGentDbContextFactory : IDesignTimeDbContextFactory<JoshTheGentDbContext>
    {
        public JoshTheGentDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<JoshTheGentDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            JoshTheGentDbContextConfigurer.Configure(builder, configuration.GetConnectionString(JoshTheGentConsts.ConnectionStringName));

            return new JoshTheGentDbContext(builder.Options);
        }
    }
}
