using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcelsiorLuxury.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ZCategorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZCategorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZMarcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZMarcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZModelos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZModelos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ZProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Modelo = table.Column<int>(type: "int", nullable: false),
                    Id_Marca = table.Column<int>(type: "int", nullable: false),
                    Id_Categoria = table.Column<int>(type: "int", nullable: false),
                    Costo = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZProductos_ZCategorias_Id_Categoria",
                        column: x => x.Id_Categoria,
                        principalTable: "ZCategorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZProductos_ZMarcas_Id_Marca",
                        column: x => x.Id_Marca,
                        principalTable: "ZMarcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZProductos_ZModelos_Id_Modelo",
                        column: x => x.Id_Modelo,
                        principalTable: "ZModelos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZDirecciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZDirecciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZDirecciones_ZUsuarios_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "ZUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZEnvios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Direccion = table.Column<int>(type: "int", nullable: false),
                    Fecha_Salida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Entrada = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Costo_Envio = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Estado_Envio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZEnvios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZEnvios_ZDirecciones_Id_Direccion",
                        column: x => x.Id_Direccion,
                        principalTable: "ZDirecciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZOrdenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false),
                    Id_Envio = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Valor_Neto = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZOrdenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZOrdenes_ZEnvios_Id_Envio",
                        column: x => x.Id_Envio,
                        principalTable: "ZEnvios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZOrdenes_ZUsuarios_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "ZUsuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ZOrdenDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Orden = table.Column<int>(type: "int", nullable: false),
                    Id_Producto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "numeric(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZOrdenDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZOrdenDetalles_ZOrdenes_Id_Orden",
                        column: x => x.Id_Orden,
                        principalTable: "ZOrdenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZOrdenDetalles_ZProductos_Id_Producto",
                        column: x => x.Id_Producto,
                        principalTable: "ZProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ZDirecciones_Id_Usuario",
                table: "ZDirecciones",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_ZEnvios_Id_Direccion",
                table: "ZEnvios",
                column: "Id_Direccion");

            migrationBuilder.CreateIndex(
                name: "IX_ZOrdenDetalles_Id_Orden",
                table: "ZOrdenDetalles",
                column: "Id_Orden");

            migrationBuilder.CreateIndex(
                name: "IX_ZOrdenDetalles_Id_Producto",
                table: "ZOrdenDetalles",
                column: "Id_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_ZOrdenes_Id_Envio",
                table: "ZOrdenes",
                column: "Id_Envio");

            migrationBuilder.CreateIndex(
                name: "IX_ZOrdenes_Id_Usuario",
                table: "ZOrdenes",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_ZProductos_Id_Categoria",
                table: "ZProductos",
                column: "Id_Categoria");

            migrationBuilder.CreateIndex(
                name: "IX_ZProductos_Id_Marca",
                table: "ZProductos",
                column: "Id_Marca");

            migrationBuilder.CreateIndex(
                name: "IX_ZProductos_Id_Modelo",
                table: "ZProductos",
                column: "Id_Modelo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZOrdenDetalles");

            migrationBuilder.DropTable(
                name: "ZOrdenes");

            migrationBuilder.DropTable(
                name: "ZProductos");

            migrationBuilder.DropTable(
                name: "ZEnvios");

            migrationBuilder.DropTable(
                name: "ZCategorias");

            migrationBuilder.DropTable(
                name: "ZMarcas");

            migrationBuilder.DropTable(
                name: "ZModelos");

            migrationBuilder.DropTable(
                name: "ZDirecciones");

            migrationBuilder.DropTable(
                name: "ZUsuarios");
        }
    }
}
