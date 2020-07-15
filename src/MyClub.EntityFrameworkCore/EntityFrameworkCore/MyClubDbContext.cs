using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyClub.Authorization.Roles;
using MyClub.Authorization.Users;
using MyClub.MultiTenancy;

namespace MyClub.EntityFrameworkCore
{
    public class MyClubDbContext : AbpZeroDbContext<Tenant, Role, User, MyClubDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyClubDbContext(DbContextOptions<MyClubDbContext> options)
            : base(options)
        {
        }
    }
}
