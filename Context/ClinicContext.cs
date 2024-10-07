using Clinic.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Context
{
    public class ClinicContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }

        public ClinicContext(DbContextOptions<ClinicContext> options)
   : base(options)
        {
        }
    }
}
