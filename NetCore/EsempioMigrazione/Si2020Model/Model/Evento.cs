using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Si2020Lib.Model
{
    [Table("TFF_Eventi")]
    public partial class Evento
    {
        [Key]
        public int ID_Evento { get; set; }
        public int ID_TipoEvento { get; set; }
        [Required]
        public int Progressivo { get; set; }
        public int ProgressivoAnno { get; set; }
        public string RifQualifica { get; set; }
        public int ID_Utente { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Data { get; set; }
        public int? ID_AmbitoEvento { get; set; }
        public string ID_Stabilimento { get; set; }
        public int? ID_Personale { get; set; }
        public string RepartoPrimario { get; set; }
        public string RepartoSecondario { get; set; }
        public string Titolo { get; set; }
        public string Descrizione { get; set; }
        public int ID_StatoEvento { get; set; }
        public int ID_PrioritaEvento { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Scadenza { get; set; }
    }
}
