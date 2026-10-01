using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using aspversion1.Models;

namespace aspversion1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, CustomerName = "Acme Corp", ContactName = "Ana Cruz", Email = "ana@acme.com", Phone = "0917-111-1001", Address = "12 Rizal St", City = "Manila", State = "NCR", ZipCode = "1000" },
                new Customer { Id = 2, CustomerName = "BlueTech", ContactName = "Ben Lim", Email = "ben@bluetech.com", Phone = "0917-111-1002", Address = "34 Mabini Ave", City = "Cebu", State = "Cebu", ZipCode = "6000" },
                new Customer { Id = 3, CustomerName = "GreenMart", ContactName = "Cara Reyes", Email = "cara@green.com", Phone = "0917-111-1003", Address = "56 Bonifacio", City = "Davao", State = "Davao", ZipCode = "8000" },
                new Customer { Id = 4, CustomerName = "SunFoods", ContactName = "Dan Tan", Email = "dan@sunfoods.com", Phone = "0917-111-1004", Address = "78 Luna St", City = "Manila", State = "NCR", ZipCode = "1001" },
                new Customer { Id = 5, CustomerName = "PrimeParts", ContactName = "Ella Santos", Email = "ella@prime.com", Phone = "0917-111-1005", Address = "9 Osmena Blvd", City = "Cebu", State = "Cebu", ZipCode = "6001" },
                new Customer { Id = 6, CustomerName = "CityCare", ContactName = "Faye Ong", Email = "faye@citycare.com", Phone = "0917-111-1006", Address = "21 Quezon Ave", City = "Davao", State = "Davao", ZipCode = "8001" },
                new Customer { Id = 7, CustomerName = "NovaSupply", ContactName = "Gio Ramos", Email = "gio@nova.com", Phone = "0917-111-1007", Address = "3 Roxas St", City = "Manila", State = "NCR", ZipCode = "1002" },
                new Customer { Id = 8, CustomerName = "StarLink", ContactName = "Hana Cruz", Email = "hana@starlink.com", Phone = "0917-111-1008", Address = "45 Aguinaldo", City = "Cebu", State = "Cebu", ZipCode = "6002" }
            );
        }
    }
}
