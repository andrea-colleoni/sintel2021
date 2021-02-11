using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Si2020Lib.Model
{
    [Table("TFF_TipiAnagrafe")]
    public class TipoAnagrafe
    {
        [Key]
        public int ID_TipoAnagrafe { get; set; }
        public bool TipoOperation { get; set; }
        public bool TipoAutomation { get; set; }
        public string AnagrafePrincipale { get; set; }
        public string Descrizione { get; set; }
        public string CodiceHardware { get; set; }
    }
}
