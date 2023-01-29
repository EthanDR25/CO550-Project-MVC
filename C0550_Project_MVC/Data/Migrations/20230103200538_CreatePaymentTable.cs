using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C0550_Project_MVC.Data.Migrations
{
    public partial class CreatePaymentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CardNumber = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    CardName = table.Column<string>(type: "nvarchar(81)", maxLength: 81, nullable: false),
                    SecurityNumber = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
