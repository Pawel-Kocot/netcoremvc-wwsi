using Microsoft.EntityFrameworkCore.Migrations;

namespace SklepInternetowy.Migrations
{
    public partial class fixspellingerror : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Frima",
                table: "Storages",
                newName: "Firma");

            migrationBuilder.RenameColumn(
                name: "Frima",
                table: "RAMs",
                newName: "Firma");

            migrationBuilder.RenameColumn(
                name: "Frima",
                table: "PSUs",
                newName: "Firma");

            migrationBuilder.RenameColumn(
                name: "Frima",
                table: "Motherboards",
                newName: "Firma");

            migrationBuilder.RenameColumn(
                name: "Frima",
                table: "GPUs",
                newName: "Firma");

            migrationBuilder.RenameColumn(
                name: "Frima",
                table: "CPUs",
                newName: "Firma");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Firma",
                table: "Storages",
                newName: "Frima");

            migrationBuilder.RenameColumn(
                name: "Firma",
                table: "RAMs",
                newName: "Frima");

            migrationBuilder.RenameColumn(
                name: "Firma",
                table: "PSUs",
                newName: "Frima");

            migrationBuilder.RenameColumn(
                name: "Firma",
                table: "Motherboards",
                newName: "Frima");

            migrationBuilder.RenameColumn(
                name: "Firma",
                table: "GPUs",
                newName: "Frima");

            migrationBuilder.RenameColumn(
                name: "Firma",
                table: "CPUs",
                newName: "Frima");
        }
    }
}
