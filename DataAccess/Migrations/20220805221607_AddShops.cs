using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddShops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO Shop (Names,OpeningHours,Address)" +
                $" VALUES ('FamilyShop','8-9 All week','La Zone')");

            migrationBuilder.Sql($"INSERT INTO Shop (Names,OpeningHours,Address)" +
               $" VALUES ('TopShop','8-10 All week','13Mai')");

            migrationBuilder.Sql($"INSERT INTO Shop (Names,OpeningHours,Address)" +
               $" VALUES ('Escale','8-9h30 All week','Joinville')");

            migrationBuilder.Sql($"INSERT INTO Shop (Names,OpeningHours,Address)" +
               $" VALUES ('Majd','8h30-10 All week','1000hgmt')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
