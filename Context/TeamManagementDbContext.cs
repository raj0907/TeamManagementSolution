using Microsoft.EntityFrameworkCore;
using TeamManagement.Models;

namespace TeamManagement.Context
{
    public class TeamManagementDbContext: DbContext
    {
        public TeamManagementDbContext(DbContextOptions<TeamManagementDbContext> options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<BusinessUnit> BusinessUnits { get; set; }
        public DbSet<BusinessUnitCategories> BusinessUnitCategories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<BusinessUnitMemebers> BusinessUnitMemebers { get; set; }

    }
}
