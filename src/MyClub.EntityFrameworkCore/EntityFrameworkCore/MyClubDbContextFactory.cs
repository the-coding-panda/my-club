using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyClub.Configuration;
using MyClub.Web;

namespace MyClub.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyClubDbContextFactory : IDesignTimeDbContextFactory<MyClubDbContext>
    {
        public MyClubDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyClubDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyClubDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyClubConsts.ConnectionStringName));

            return new MyClubDbContext(builder.Options);
        }
    }
}
