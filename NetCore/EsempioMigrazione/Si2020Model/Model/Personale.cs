using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Si2020Lib.Model
{
    [Table("VFF_Personale")]
    public class Personale
    {
        [Key]
        public int ID_Personale { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string RepartoPrincipale { get; set; }
        public string RepartoSecondario { get; set; }
        public int Stato { get; set; }
        //[ForeignKey("ID_Personale")]
        public virtual List<LDAP> LDAP { get; set; }
    }
}
