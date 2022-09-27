using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.App.Persistencia.Migrations
{
    public partial class seagregopaisyciudad2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Ciudad_ciudadId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Pais_paisId",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pais",
                table: "Pais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ciudad",
                table: "Ciudad");

            migrationBuilder.RenameTable(
                name: "Pais",
                newName: "Paises");

            migrationBuilder.RenameTable(
                name: "Ciudad",
                newName: "Ciudades");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paises",
                table: "Paises",
                column: "paisId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades",
                column: "ciudadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Ciudades_ciudadId",
                table: "Clientes",
                column: "ciudadId",
                principalTable: "Ciudades",
                principalColumn: "ciudadId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Paises_paisId",
                table: "Clientes",
                column: "paisId",
                principalTable: "Paises",
                principalColumn: "paisId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Ciudades_ciudadId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Paises_paisId",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paises",
                table: "Paises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades");

            migrationBuilder.RenameTable(
                name: "Paises",
                newName: "Pais");

            migrationBuilder.RenameTable(
                name: "Ciudades",
                newName: "Ciudad");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pais",
                table: "Pais",
                column: "paisId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ciudad",
                table: "Ciudad",
                column: "ciudadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Ciudad_ciudadId",
                table: "Clientes",
                column: "ciudadId",
                principalTable: "Ciudad",
                principalColumn: "ciudadId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Pais_paisId",
                table: "Clientes",
                column: "paisId",
                principalTable: "Pais",
                principalColumn: "paisId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
