using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using IdentityTaskDay9.ViewModels;

namespace LayersAndIdentity.Models;

public class CompanyDBContext : IdentityDbContext<ApplicationUser>
{
    public CompanyDBContext()
    {

    }
    public CompanyDBContext(DbContextOptions options):base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-S4IHD99\\SS17;Initial Catalog= IdentityMVC;Integrated Security=True;TrustServerCertificate = True;");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DepartmentLocation>().HasKey("DeptNumber", "Location");
        modelBuilder.Entity<WorksOnProject>().HasKey("EmpSSN", "projNum");
        modelBuilder.Entity<Dependent>().HasKey("EmpSSN", "Name");

        modelBuilder.Entity<ApplicationUser>().HasOne(s => s.Supervisor).WithMany(e => e.Employees);

        modelBuilder.Entity<ApplicationUser>().HasOne(e => e.DepartmentManege).WithOne(d => d.EmployeeManege);
        modelBuilder.Entity<ApplicationUser>().HasOne(e => e.DepartmentWork).WithMany(e => e.EmployeesWork);
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<ApplicationUser> Employees { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<DepartmentLocation> DepartmentLocation { get; set; }
    public DbSet<WorksOnProject> WorksOnProjects { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Dependent> Dependents { get; set; }
    public DbSet<IdentityTaskDay9.ViewModels.RegistrationVM> RegistrationVM { get; set; } = default!;
    public DbSet<IdentityTaskDay9.ViewModels.LoginVM> LoginVM { get; set; } = default!;
    public DbSet<IdentityTaskDay9.ViewModels.ProfileVM> ProfileVM { get; set; } = default!;


}
