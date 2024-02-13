using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDHospital.Migrations
{
    /// <inheritdoc />
    public partial class Celular : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Celular",
                table: "Profissionais",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Celular",
                table: "Db_Pacientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Profissionais");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Db_Pacientes");
        }
    }
}
