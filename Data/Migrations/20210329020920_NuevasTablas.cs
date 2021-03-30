using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaAdminTaller.Data.Migrations
{
    public partial class NuevasTablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Cliente_ClienteID",
                table: "Vehiculo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehiculo",
                table: "Vehiculo");

            migrationBuilder.RenameTable(
                name: "Vehiculo",
                newName: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Vehiculos",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculo_ClienteID",
                table: "Vehiculos",
                newName: "IX_Vehiculos_ClienteId");

            migrationBuilder.AlterColumn<string>(
                name: "Patente",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Vehiculos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "Averia",
                table: "Vehiculos",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Vehiculos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEntrada",
                table: "Vehiculos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaSalida",
                table: "Vehiculos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Vehiculos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "MecanicoId",
                table: "Vehiculos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Presupuesto",
                table: "Vehiculos",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Mecanicos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DNI = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mecanicos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Repuestos",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repuestos", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_MecanicoId",
                table: "Vehiculos",
                column: "MecanicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Cliente_ClienteId",
                table: "Vehiculos",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Mecanicos_MecanicoId",
                table: "Vehiculos",
                column: "MecanicoId",
                principalTable: "Mecanicos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Cliente_ClienteId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Mecanicos_MecanicoId",
                table: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Mecanicos");

            migrationBuilder.DropTable(
                name: "Repuestos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehiculos",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_MecanicoId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Averia",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "FechaEntrada",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "FechaSalida",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "MecanicoId",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "Presupuesto",
                table: "Vehiculos");

            migrationBuilder.RenameTable(
                name: "Vehiculos",
                newName: "Vehiculo");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Vehiculo",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_ClienteId",
                table: "Vehiculo",
                newName: "IX_Vehiculo_ClienteID");

            migrationBuilder.AlterColumn<string>(
                name: "Patente",
                table: "Vehiculo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Vehiculo",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehiculo",
                table: "Vehiculo",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Cliente_ClienteID",
                table: "Vehiculo",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
