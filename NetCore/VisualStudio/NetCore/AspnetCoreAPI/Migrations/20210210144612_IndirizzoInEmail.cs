using Microsoft.EntityFrameworkCore.Migrations;

namespace AspnetCoreAPI.Migrations
{
    public partial class IndirizzoInEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Indirizzo",
                table: "Persone",
                newName: "Email");

            migrationBuilder.Sql(@"
                INSERT INTO Persone (CodiceFiscale, Nome) VALUES ('ABCD', 'Andrea');        
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Persone",
                newName: "Indirizzo");
        }
    }
}
