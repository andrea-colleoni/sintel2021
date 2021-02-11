using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Si2020Lib.Model
{
    [Table("VFF_LDAP")]
    public class LDAP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_LDAP { get; set; }
        public int ID_Personale { get; set; }
        public string LoginLDAP { get; set; }
        public bool Attivo { get; set; }
        [JsonIgnore]
        [ForeignKey("ID_Personale")]
        public virtual Personale Personale { get; set; }
    }
}
