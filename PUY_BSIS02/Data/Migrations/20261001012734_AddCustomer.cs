using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace aspversion1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: false),
                    ContactName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    ZipCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "ContactName", "CustomerName", "Email", "Phone", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1, "12 Rizal St", "Manila", "Ana Cruz", "Acme Corp", "ana@acme.com", "0917-111-1001", "NCR", "1000" },
                    { 2, "34 Mabini Ave", "Cebu", "Ben Lim", "BlueTech", "ben@bluetech.com", "0917-111-1002", "Cebu", "6000" },
                    { 3, "56 Bonifacio", "Davao", "Cara Reyes", "GreenMart", "cara@green.com", "0917-111-1003", "Davao", "8000" },
                    { 4, "78 Luna St", "Manila", "Dan Tan", "SunFoods", "dan@sunfoods.com", "0917-111-1004", "NCR", "1001" },
                    { 5, "9 Osmena Blvd", "Cebu", "Ella Santos", "PrimeParts", "ella@prime.com", "0917-111-1005", "Cebu", "6001" },
                    { 6, "21 Quezon Ave", "Davao", "Faye Ong", "CityCare", "faye@citycare.com", "0917-111-1006", "Davao", "8001" },
                    { 7, "3 Roxas St", "Manila", "Gio Ramos", "NovaSupply", "gio@nova.com", "0917-111-1007", "NCR", "1002" },
                    { 8, "45 Aguinaldo", "Cebu", "Hana Cruz", "StarLink", "hana@starlink.com", "0917-111-1008", "Cebu", "6002" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
