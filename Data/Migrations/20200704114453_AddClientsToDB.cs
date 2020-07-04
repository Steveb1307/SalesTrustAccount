using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesTrustAccount.Data.Migrations
{
    public partial class AddClientsToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    OtherNames = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    Suburb = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: false),
                    MobilePhone = table.Column<string>(nullable: false),
                    PhoneWork = table.Column<string>(nullable: true),
                    PhoneHome = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    BankBSB = table.Column<string>(nullable: true),
                    BankAccNumber = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
