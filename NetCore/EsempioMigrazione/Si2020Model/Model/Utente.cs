using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Si2020Lib.Model
{
    [Table("TFF_Utenti")]
    public partial class Utente
    {
        [Key]
        public int ID_Utente { get; set; }
        public string Dominio { get; set; }
        public string Login { get; set; }
        public string CognomeNome { get; set; }
        public bool UtenteOperation { get; set; }
        public bool UtenteAutomation { get; set; }
        public bool Attivo { get; set; }
        public int? Ordinamento { get; set; }
    }
}