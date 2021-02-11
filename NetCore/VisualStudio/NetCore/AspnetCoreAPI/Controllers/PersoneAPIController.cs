using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreCL;
using NetStdCL.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreAPI.Controllers
{
    [Route("api/persone")]
    [ApiController]
    public class PersoneAPIController : ControllerBase
    {
        private readonly CorsoContext _db;

        public PersoneAPIController(
            CorsoContext db
            )
        {
            this._db = db;
        }

        /// <summary>
        /// Ottiene l'elenco delle persone
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ICollection<Persona>> all()
        {
            return await this._db.Persone.ToListAsync();
        }

        /// <summary>
        /// Ottiene una persona per chiave
        /// </summary>
        /// <param name="codiceFiscale">Codice fiscale della persona</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{codiceFiscale}")]
        public async Task<ActionResult<Persona>> byKey(string codiceFiscale)
        {
            var p = await this._db.Persone.FindAsync(codiceFiscale);
            if (p == null)
                return NotFound(new { reason = "persona non trovata" });
            return Ok(p);
        }
    }
}
