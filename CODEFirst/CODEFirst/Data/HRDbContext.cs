using CODEFirst.Models;
using Microsoft.EntityFrameworkCore;
public class HRDbContext : DbContext
{
    public HRDbContext(DbContextOptions<HRDbContext> options) : base(options) { }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }
}