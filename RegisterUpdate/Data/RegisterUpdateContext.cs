using Microsoft.EntityFrameworkCore;
using RegisterUpdate.Models;

namespace RegisterUpdate.Data
{
    public class RegisterUpdateContext : DbContext
    {
        public RegisterUpdateContext(DbContextOptions<RegisterUpdateContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
    }
}
