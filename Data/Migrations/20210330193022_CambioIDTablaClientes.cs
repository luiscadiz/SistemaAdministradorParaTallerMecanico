using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaAdminTaller.Data.Migrations
{
    public partial class CambioIDTablaClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Cliente_ClienteId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Mecanicos_MecanicoId",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "MecanicoId",
                table: "Vehiculos",
                newName: "MecanicoID");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Vehiculos",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_MecanicoId",
                table: "Vehiculos",
                newName: "IX_Vehiculos_MecanicoID");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_ClienteId",
                table: "Vehiculos",
                newName: "IX_Vehiculos_ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Cliente_ClienteID",
                table: "Vehiculos",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Mecanicos_MecanicoID",
                table: "Vehiculos",
                column: "MecanicoID",
                principalTable: "Mecanicos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Cliente_ClienteID",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Mecanicos_MecanicoID",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "MecanicoID",
                table: "Vehiculos",
                newName: "MecanicoId");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Vehiculos",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_MecanicoID",
                table: "Vehiculos",
                newName: "IX_Vehiculos_MecanicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_ClienteID",
                table: "Vehiculos",
                newName: "IX_Vehiculos_ClienteId");

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
    }
}
