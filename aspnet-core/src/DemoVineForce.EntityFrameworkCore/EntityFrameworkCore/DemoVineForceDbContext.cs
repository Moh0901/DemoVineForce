using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DemoVineForce.Authorization.Roles;
using DemoVineForce.Authorization.Users;
using DemoVineForce.MultiTenancy;
using DemoVineForce.Authorization.Entities;

namespace DemoVineForce.EntityFrameworkCore
{
    public class DemoVineForceDbContext : AbpZeroDbContext<Tenant, Role, User, DemoVineForceDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }

        /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
              modelBuilder.Entity<State>()
                  .HasOne(s => s.Country)
                  .WithMany(c => c.States)
                  .HasForeignKey(s => s.CountryId);
          }*/

        public DemoVineForceDbContext(DbContextOptions<DemoVineForceDbContext> options)
            : base(options)
        {
        }
    }
}
