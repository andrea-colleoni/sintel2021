using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Si2020Lib.Model
{
    [Table("TFF_StatiAnagrafe")]
    public class StatoAnagrafe
    {
        [Key]
        public int ID_StatoAnagrafe { get; set; }
        public string Descrizione { get; set; }
        public int? Ordinamento { get; set; }
    }
}
