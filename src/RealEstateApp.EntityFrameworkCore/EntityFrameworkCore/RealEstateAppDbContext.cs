using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RealEstateApp.Authorization.Roles;
using RealEstateApp.Authorization.Users;
using RealEstateApp.MultiTenancy;

namespace RealEstateApp.EntityFrameworkCore
{
    public class RealEstateAppDbContext : AbpZeroDbContext<Tenant, Role, User, RealEstateAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public RealEstateAppDbContext(DbContextOptions<RealEstateAppDbContext> options)
            : base(options)
        {
        }
    }
}
