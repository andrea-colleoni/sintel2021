using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Si2020Lib.Model
{ 
    [Table("TFF_Log")]
   public partial class Log
    {
        [Key]
        public int ID_Log { get; set; }
        public string RiferimentoLog { get; set; }
        public string Utente { get; set; }
        public DateTime DataOra { get; set; }
        public string TipoOperazione { get; set; }
        public string CampoVariato { get; set; }
        public string CampoVariatoLabel { get; set; }
        public string ValorePrecedente { get; set; }
        public string ValoreSuccessivo { get; set; }
    }
}
