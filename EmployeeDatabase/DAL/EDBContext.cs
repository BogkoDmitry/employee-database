using EmployeeDatabase.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDatabase.DAL
{
    public sealed class EDBContext : DbContext
    {
        public EDBContext(DbContextOptions<EDBContext> options): base(options) { }
        
        DbSet<User> Users { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Project> Projects { get; set; }
        DbSet<WorkTimeType> WorkTimeTypes { get; set; }
        DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
