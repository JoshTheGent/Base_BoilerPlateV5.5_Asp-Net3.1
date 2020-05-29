using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using JoshTheGent.Authorization.Roles;
using JoshTheGent.Authorization.Users;
using JoshTheGent.MultiTenancy;

namespace JoshTheGent.EntityFrameworkCore
{
    public class JoshTheGentDbContext : AbpZeroDbContext<Tenant, Role, User, JoshTheGentDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public JoshTheGentDbContext(DbContextOptions<JoshTheGentDbContext> options)
            : base(options)
        {
        }
    }
}
