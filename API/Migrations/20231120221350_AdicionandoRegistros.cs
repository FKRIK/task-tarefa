using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class AdicionandoRegistros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 21, 19, 13, 50, 438, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 22, 19, 13, 50, 438, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 19, 13, 50, 438, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 19, 13, 50, 438, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 19, 13, 50, 438, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 4, 19, 13, 50, 438, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "TarefaId", "CategoriaId", "CriadoEm", "Descricao", "Status", "Titulo" },
                values: new object[] { 4, 1, new DateTime(2023, 11, 30, 19, 13, 50, 438, DateTimeKind.Local).AddTicks(2296), "Substituir processador por um novo", "Não iniciada", "Consertar o computador" });

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "TarefaId", "CategoriaId", "CriadoEm", "Descricao", "Status", "Titulo" },
                values: new object[] { 5, 2, new DateTime(2023, 12, 4, 19, 13, 50, 438, DateTimeKind.Local).AddTicks(2298), "Prosseguir com a pesquisa sobre ML", "Não iniciada", "Continuar pesquisa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 21, 18, 53, 46, 822, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 22, 18, 53, 46, 822, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 18, 53, 46, 822, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 1,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 27, 18, 53, 46, 822, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 2,
                column: "CriadoEm",
                value: new DateTime(2023, 11, 23, 18, 53, 46, 822, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: 3,
                column: "CriadoEm",
                value: new DateTime(2023, 12, 4, 18, 53, 46, 822, DateTimeKind.Local).AddTicks(8293));
        }
    }
}
