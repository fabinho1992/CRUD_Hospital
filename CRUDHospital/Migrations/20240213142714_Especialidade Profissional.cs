using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDHospital.Migrations
{
    /// <inheritdoc />
    public partial class EspecialidadeProfissional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EspecialidadeId",
                table: "Consultas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "_DbEspecialidadeProfissional",
                columns: table => new
                {
                    ProfissionalId = table.Column<int>(type: "int", nullable: false),
                    EspecialidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__DbEspecialidadeProfissional", x => new { x.ProfissionalId, x.EspecialidadeId });
                    table.ForeignKey(
                        name: "FK__DbEspecialidadeProfissional_Especialidades_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalTable: "Especialidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__DbEspecialidadeProfissional_Profissionais_ProfissionalId",
                        column: x => x.ProfissionalId,
                        principalTable: "Profissionais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            
            migrationBuilder.CreateIndex(
                name: "IX_Consultas_EspecialidadeId",
                table: "Consultas",
                column: "EspecialidadeId");

            migrationBuilder.CreateIndex(
                name: "IX__DbEspecialidadeProfissional_EspecialidadeId",
                table: "_DbEspecialidadeProfissional",
                column: "EspecialidadeId");


            migrationBuilder.AddForeignKey(
                name: "FK_Consultas_Especialidades_EspecialidadeId",
                table: "Consultas",
                column: "EspecialidadeId",
                principalTable: "Especialidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultas_Especialidades_EspecialidadeId",
                table: "Consultas");

            migrationBuilder.DropTable(
                name: "_DbEspecialidadeProfissional");

            migrationBuilder.DropTable(
                name: "EspecialidadeProfissional");

            migrationBuilder.DropIndex(
                name: "IX_Consultas_EspecialidadeId",
                table: "Consultas");

            migrationBuilder.DropColumn(
                name: "EspecialidadeId",
                table: "Consultas");
        }
    }
}
