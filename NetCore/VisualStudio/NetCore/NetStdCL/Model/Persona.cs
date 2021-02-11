using System.ComponentModel.DataAnnotations;

namespace NetStdCL.Model
{
    public class Persona
    {
        [Key]
        public string CodiceFiscale { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public string Email { get; set; }
    }
}
