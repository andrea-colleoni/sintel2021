using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Si2020Lib.Context;
using Si2020Lib.Model;

namespace Si2020Api.Controllers
{
    [ApiController]
    public class UtentiController : ControllerBase
    {
        private SiDb db;

        public UtentiController(
            SiDb db
            )
        {
            this.db = db;
        }

        [HttpGet]
        [Route("api/Utenti")]
        public IQueryable<Utente> GetUtenti()
        {
            return db.Utenti.OrderBy(u => u.Ordinamento);
        }

        [Authorize]
        [HttpGet]
        [Route("api/Utenti/{id}")]
        public async Task<ActionResult<Utente>> GetUtente(int id)
        {
            Utente utente = await db.Utenti.FindAsync(id);
            if (utente == null)
            {
                return NotFound();
            }
            return Ok(utente);
        }
    }
}