using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Si2020Lib.Model
{
    [Table("TFF_Garanzie")]
    public class Garanzia
    {
        [Key]
        public int ID_Garanzia { get; set; }
        public string ID_Anagrafe { get; set; }
        public string SerialNumber { get; set; }
        public string Fornitore { get; set; }
        public DateTime DataAcquisto { get; set; }
        public int? MesiGaranzia { get; set; }
        public DateTime ScadenzaGaranzia { get; set; }
        public string TipoGaranzia { get; set; }
    }
}
