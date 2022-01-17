using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmesApiAlura.Migrations
{
    public partial class FixtypoinfieldonSessao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "HoarioDeEncerramento",
            //    table: "Sessoes",
            //    newName: "HorarioDeEncerramento");

            migrationBuilder.Sql("ALTER TABLE Sessoes CHANGE HoarioDeEncerramento HorarioDeEncerramento DATETIME");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.RenameColumn(
            //    name: "HorarioDeEncerramento",
            //    table: "Sessoes",
            //    newName: "HoarioDeEncerramento");
            migrationBuilder.Sql("ALTER TABLE Sessoes CHANGE HorarioDeEncerramento HoarioDeEncerramento DATETIME");
        }
    }
}
