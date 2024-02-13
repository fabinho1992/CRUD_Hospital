using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDHospital.Migrations
{
    /// <inheritdoc />
    public partial class ConsultaProfissional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfissionalId",
                table: "Consultas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_ProfissionalId",
                table: "Consultas",
                column: "ProfissionalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Profissionais_ProfissionalId",
                table: "Consultas",
                column: "ProfissionalId",
                principalTable: "Profissionais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Profissionais_ProfissionalId",
                table: "Consultas");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_ProfissionalId",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "ProfissionalId",
                table: "Consultas");
        }
    }
}
