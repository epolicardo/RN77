using Microsoft.EntityFrameworkCore.Migrations;

namespace RN77.BD.Migrations
{
    public partial class ActualizacionPais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaModif",
                table: "AspNetUsers",
                newName: "FechaModifReg");

            migrationBuilder.RenameColumn(
                name: "FechaCrea",
                table: "AspNetUsers",
                newName: "FechaCreaReg");

            migrationBuilder.RenameColumn(
                name: "FechaBaja",
                table: "AspNetUsers",
                newName: "FechaBajaReg");

            migrationBuilder.AlterColumn<string>(
                name: "NombreProvincia",
                table: "Provincias",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombrePais",
                table: "Paises",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "CodigoPais",
                table: "Paises",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCiudad",
                table: "Ciudades",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IQ_NombreProvincia",
                table: "Provincias",
                column: "NombreProvincia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IQ_NombrePais",
                table: "Paises",
                column: "NombrePais",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IQ_NombreCiudad",
                table: "Ciudades",
                column: "NombreCiudad",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IQ_NombreProvincia",
                table: "Provincias");

            migrationBuilder.DropIndex(
                name: "IQ_NombrePais",
                table: "Paises");

            migrationBuilder.DropIndex(
                name: "IQ_NombreCiudad",
                table: "Ciudades");

            migrationBuilder.DropColumn(
                name: "CodigoPais",
                table: "Paises");

            migrationBuilder.RenameColumn(
                name: "FechaModifReg",
                table: "AspNetUsers",
                newName: "FechaModif");

            migrationBuilder.RenameColumn(
                name: "FechaCreaReg",
                table: "AspNetUsers",
                newName: "FechaCrea");

            migrationBuilder.RenameColumn(
                name: "FechaBajaReg",
                table: "AspNetUsers",
                newName: "FechaBaja");

            migrationBuilder.AlterColumn<string>(
                name: "NombreProvincia",
                table: "Provincias",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NombrePais",
                table: "Paises",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NombreCiudad",
                table: "Ciudades",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
