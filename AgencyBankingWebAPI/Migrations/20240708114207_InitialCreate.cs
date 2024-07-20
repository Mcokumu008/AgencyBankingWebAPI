using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgencyBankingWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcctNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BookedBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClearedBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustMemoLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustMemoLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustMemoLine3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExchangeRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentRef = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
