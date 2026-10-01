using Microsoft.EntityFrameworkCore;
using Tanjente_Asp.Net.Models;

namespace Tanjente_Asp.Net.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}