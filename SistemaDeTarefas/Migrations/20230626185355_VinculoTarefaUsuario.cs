using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeTarefas.Migrations
{
    public partial class VinculoTarefaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tarefas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tarefas_UserId",
                table: "Tarefas",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tarefas_Usuarios_UserId",
                table: "Tarefas",
                column: "UserId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tarefas_Usuarios_UserId",
                table: "Tarefas");

            migrationBuilder.DropIndex(
                name: "IX_Tarefas_UserId",
                table: "Tarefas");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tarefas");
        }
    }
}
