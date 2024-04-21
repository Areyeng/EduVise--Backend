using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EduVise.Authorization.Roles;
using EduVise.Authorization.Users;
using EduVise.MultiTenancy;

namespace EduVise.EntityFrameworkCore
{
    public class EduViseDbContext : AbpZeroDbContext<Tenant, Role, User, EduViseDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public EduViseDbContext(DbContextOptions<EduViseDbContext> options)
            : base(options)
        {
        }
    }
}
