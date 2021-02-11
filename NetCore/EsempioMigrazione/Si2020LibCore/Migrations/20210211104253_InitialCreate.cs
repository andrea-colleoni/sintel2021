using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Si2020LibCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TFF_Eventi",
                columns: table => new
                {
                    ID_Evento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_TipoEvento = table.Column<int>(type: "int", nullable: false),
                    Progressivo = table.Column<int>(type: "int", nullable: false),
                    ProgressivoAnno = table.Column<int>(type: "int", nullable: false),
                    RifQualifica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_Utente = table.Column<int>(type: "int", nullable: false),
                    Data = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ID_AmbitoEvento = table.Column<int>(type: "int", nullable: true),
                    ID_Stabilimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_Personale = table.Column<int>(type: "int", nullable: true),
                    RepartoPrimario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepartoSecondario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titolo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_StatoEvento = table.Column<int>(type: "int", nullable: false),
                    ID_PrioritaEvento = table.Column<int>(type: "int", nullable: false),
                    Scadenza = table.Column<DateTime>(type: "smalldatetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFF_Eventi", x => x.ID_Evento);
                });

            migrationBuilder.CreateTable(
                name: "TFF_Garanzie",
                columns: table => new
                {
                    ID_Garanzia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Anagrafe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fornitore = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAcquisto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesiGaranzia = table.Column<int>(type: "int", nullable: true),
                    ScadenzaGaranzia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoGaranzia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFF_Garanzie", x => x.ID_Garanzia);
                });

            migrationBuilder.CreateTable(
                name: "TFF_Log",
                columns: table => new
                {
                    ID_Log = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiferimentoLog = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Utente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataOra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoOperazione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampoVariato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampoVariatoLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorePrecedente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValoreSuccessivo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFF_Log", x => x.ID_Log);
                });

            migrationBuilder.CreateTable(
                name: "TFF_SistemiOperativi",
                columns: table => new
                {
                    ID_SistemaOperativo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ordinamento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFF_SistemiOperativi", x => x.ID_SistemaOperativo);
                });

            migrationBuilder.CreateTable(
                name: "TFF_StatiAnagrafe",
                columns: table => new
                {
                    ID_StatoAnagrafe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ordinamento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFF_StatiAnagrafe", x => x.ID_StatoAnagrafe);
                });

            migrationBuilder.CreateTable(
                name: "TFF_StatiQualifica",
                columns: table => new
                {
                    ID_StatoQualifica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFF_StatiQualifica", x => x.ID_StatoQualifica);
                });

            migrationBuilder.CreateTable(
                name: "TFF_TipiAnagrafe",
                columns: table => new
                {
                    ID_TipoAnagrafe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoOperation = table.Column<bool>(type: "bit", nullable: false),
                    TipoAutomation = table.Column<bool>(type: "bit", nullable: false),
                    AnagrafePrincipale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodiceHardware = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFF_TipiAnagrafe", x => x.ID_TipoAnagrafe);
                });

            migrationBuilder.CreateTable(
                name: "TFF_Utenti",
                columns: table => new
                {
                    ID_Utente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dominio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CognomeNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UtenteOperation = table.Column<bool>(type: "bit", nullable: false),
                    UtenteAutomation = table.Column<bool>(type: "bit", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false),
                    Ordinamento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TFF_Utenti", x => x.ID_Utente);
                });

            migrationBuilder.CreateTable(
                name: "VFF_Personale",
                columns: table => new
                {
                    ID_Personale = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepartoPrincipale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepartoSecondario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stato = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VFF_Personale", x => x.ID_Personale);
                });

            migrationBuilder.CreateTable(
                name: "VFF_LDAP",
                columns: table => new
                {
                    ID_LDAP = table.Column<int>(type: "int", nullable: false),
                    ID_Personale = table.Column<int>(type: "int", nullable: false),
                    LoginLDAP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VFF_LDAP", x => x.ID_LDAP);
                    table.ForeignKey(
                        name: "FK_VFF_LDAP_VFF_Personale_ID_Personale",
                        column: x => x.ID_Personale,
                        principalTable: "VFF_Personale",
                        principalColumn: "ID_Personale",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VFF_LDAP_ID_Personale",
                table: "VFF_LDAP",
                column: "ID_Personale");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TFF_Eventi");

            migrationBuilder.DropTable(
                name: "TFF_Garanzie");

            migrationBuilder.DropTable(
                name: "TFF_Log");

            migrationBuilder.DropTable(
                name: "TFF_SistemiOperativi");

            migrationBuilder.DropTable(
                name: "TFF_StatiAnagrafe");

            migrationBuilder.DropTable(
                name: "TFF_StatiQualifica");

            migrationBuilder.DropTable(
                name: "TFF_TipiAnagrafe");

            migrationBuilder.DropTable(
                name: "TFF_Utenti");

            migrationBuilder.DropTable(
                name: "VFF_LDAP");

            migrationBuilder.DropTable(
                name: "VFF_Personale");
        }
    }
}
