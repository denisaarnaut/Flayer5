using Microsoft.EntityFrameworkCore.Migrations;

namespace Flayer5.Migrations
{
    public partial class BiletPachet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanieID",
                table: "Bilet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Companie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Companie = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pachet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Pachet = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pachet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BiletPachet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BiletID = table.Column<int>(type: "int", nullable: false),
                    PachetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiletPachet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BiletPachet_Bilet_BiletID",
                        column: x => x.BiletID,
                        principalTable: "Bilet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BiletPachet_Pachet_PachetID",
                        column: x => x.PachetID,
                        principalTable: "Pachet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilet_CompanieID",
                table: "Bilet",
                column: "CompanieID");

            migrationBuilder.CreateIndex(
                name: "IX_BiletPachet_BiletID",
                table: "BiletPachet",
                column: "BiletID");

            migrationBuilder.CreateIndex(
                name: "IX_BiletPachet_PachetID",
                table: "BiletPachet",
                column: "PachetID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bilet_Companie_CompanieID",
                table: "Bilet",
                column: "CompanieID",
                principalTable: "Companie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilet_Companie_CompanieID",
                table: "Bilet");

            migrationBuilder.DropTable(
                name: "BiletPachet");

            migrationBuilder.DropTable(
                name: "Companie");

            migrationBuilder.DropTable(
                name: "Pachet");

            migrationBuilder.DropIndex(
                name: "IX_Bilet_CompanieID",
                table: "Bilet");

            migrationBuilder.DropColumn(
                name: "CompanieID",
                table: "Bilet");
        }
    }
}
