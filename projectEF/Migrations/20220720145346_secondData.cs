using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectEF.Migrations
{
    public partial class secondData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorie",
                columns: new[] { "CategorieId", "Description", "Name", "Peso" },
                values: new object[] { new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b404"), null, "Actividad Realizada", 10 });

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b410"),
                column: "CreationDate",
                value: new DateTime(2022, 7, 20, 9, 53, 46, 349, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b412"),
                column: "CreationDate",
                value: new DateTime(2022, 7, 20, 9, 53, 46, 349, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "CategoriId", "CreationDate", "Description", "PrioritiTask", "Tittle" },
                values: new object[] { new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b414"), new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b404"), new DateTime(2022, 7, 20, 9, 53, 46, 349, DateTimeKind.Local).AddTicks(7761), null, 2, "Aprender a Programar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b414"));

            migrationBuilder.DeleteData(
                table: "Categorie",
                keyColumn: "CategorieId",
                keyValue: new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b404"));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b410"),
                column: "CreationDate",
                value: new DateTime(2022, 7, 20, 9, 26, 59, 619, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: new Guid("14c0ef6a-3e32-44c6-8f16-5d1eb935b412"),
                column: "CreationDate",
                value: new DateTime(2022, 7, 20, 9, 26, 59, 619, DateTimeKind.Local).AddTicks(6095));
        }
    }
}
