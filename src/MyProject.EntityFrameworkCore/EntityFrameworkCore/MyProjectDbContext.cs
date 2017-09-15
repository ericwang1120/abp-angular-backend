using Abp.Zero.EntityFrameworkCore;
using MyProject.Authorization.Roles;
using MyProject.Authorization.Users;
using MyProject.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using MyProject.PolesManagement.Poles;
using MyProject.PolesManagement.PoleCategories;
using MyProject.PolesManagement.Lines;


namespace MyProject.EntityFrameworkCore
{
    public class MyProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjectDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        public DbSet<Pole> Poles { get; set; }
        public DbSet<Line> Lines { get; set; }
        public DbSet<PoleCategory> PoleCategories { get; set; }

        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options)
            : base(options)
        {

        }
    }
}
