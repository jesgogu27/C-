using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectEF.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Task",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categorie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categorie",
                columns: new[] { "CategorieId", "Description", "Name", "Peso" },
                values: new object[] { new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b402"), null, "Actividades Personales", 50 });

            migrationBuilder.InsertData(
                table: "Categorie",
                columns: new[] { "CategorieId", "Description", "Name", "Peso" },
                values: new object[] { new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b49d"), null, "Actividades pendientes", 20 });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "CategoriId", "CreationDate", "Description", "PrioritiTask", "Tittle" },
                values: new object[] { new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b410"), new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b49d"), new DateTime(2022, 7, 20, 9, 26, 59, 619, DateTimeKind.Local).AddTicks(6066), null, 1, "Pagos pendientes" });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "CategoriId", "CreationDate", "Description", "PrioritiTask", "Tittle" },
                values: new object[] { new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b412"), new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b402"), new DateTime(2022, 7, 20, 9, 26, 59, 619, DateTimeKind.Local).AddTicks(6095), null, 0, "Terminar PElicula en Netflix" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b410"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b412"));

            migrationBuilder.DeleteData(
                table: "Categorie",
                keyColumn: "CategorieId",
                keyValue: new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b402"));

            migrationBuilder.DeleteData(
                table: "Categorie",
                keyColumn: "CategorieId",
                keyValue: new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b49d"));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Task",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categorie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
