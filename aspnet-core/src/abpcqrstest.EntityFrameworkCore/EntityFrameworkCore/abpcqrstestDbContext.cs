using Abp.Zero.EntityFrameworkCore;
using abpcqrstest.Authorization.Roles;
using abpcqrstest.Authorization.Users;
using abpcqrstest.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace abpcqrstest.EntityFrameworkCore;

public class abpcqrstestDbContext : AbpZeroDbContext<Tenant, Role, User, abpcqrstestDbContext>
{
    /* Define a DbSet for each entity of the application */

    public abpcqrstestDbContext(DbContextOptions<abpcqrstestDbContext> options)
        : base(options)
    {
    }

    public DbSet<Items.Item> Items { get; set; }
}
