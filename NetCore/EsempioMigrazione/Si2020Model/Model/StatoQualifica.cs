using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Si2020Lib.Model
{
    [Table("TFF_StatiQualifica")]
    public class StatoQualifica
    {
        [Key]
        public int ID_StatoQualifica { get; set; }
        public string Descrizione { get; set; }
    }
}
