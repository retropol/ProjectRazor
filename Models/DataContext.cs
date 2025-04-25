using Microsoft.EntityFrameworkCore;

namespace ProjectRazor.Models
{
    public class DataContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=MEHMET;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
