using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Si2020Lib.Model
{
    [Table("TFF_SistemiOperativi")]
    public class SistemaOperativo
    {
        [Key]
        public int ID_SistemaOperativo { get; set; }
        public string Descrizione { get; set; }
        public int? Ordinamento { get; set; }
    }
}
