using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoCiclo3.App.Persistencia.Migrations
{
    public partial class MigraInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kilometraje = table.Column<int>(type: "int", nullable: false),
                    numeroasientos = table.Column<int>(type: "int", nullable: false),
                    placa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Estaciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coord_x = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    coord_y = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estaciones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Rutas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    origenid = table.Column<int>(type: "int", nullable: true),
                    destinoid = table.Column<int>(type: "int", nullable: true),
                    tiempo_estimado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rutas_Estaciones_destinoid",
                        column: x => x.destinoid,
                        principalTable: "Estaciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rutas_Estaciones_origenid",
                        column: x => x.origenid,
                        principalTable: "Estaciones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rutas_destinoid",
                table: "Rutas",
                column: "destinoid");

            migrationBuilder.CreateIndex(
                name: "IX_Rutas_origenid",
                table: "Rutas",
                column: "origenid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "Rutas");

            migrationBuilder.DropTable(
                name: "Estaciones");
        }
    }
}
