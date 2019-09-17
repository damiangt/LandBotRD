using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LandBotRD.Web.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Identificacion = table.Column<string>(maxLength: 10, nullable: false),
                    Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Celular = table.Column<string>(maxLength: 10, nullable: false),
                    NombresLinea = table.Column<string>(maxLength: 50, nullable: true),
                    CelularLinea = table.Column<string>(maxLength: 10, nullable: true),
                    HoraLinea = table.Column<string>(maxLength: 8, nullable: true),
                    FechaRegistro = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<string>(maxLength: 20, nullable: true),
                    Observaciones = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });


            migrationBuilder.CreateTable(
               name: "Estado",
               columns: table => new
               {
                   Id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                   Descripcion = table.Column<string>(maxLength: 50, nullable: false),
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Estado", x => x.Id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Estado");
        }




    }
}
