using System.Data;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Si2020Api.Models;
using Si2020Lib.Context;
using Si2020Lib.Model;

namespace Si2020Api.Controllers
{
    [ApiController]
    public class PersonaleController : ControllerBase
    {
        private SiDb db;

        public PersonaleController(
            SiDb db
            )
        {
            this.db = db;
        }

        [HttpGet]
        [Route("api/Personale")]
        public IQueryable<Personale> GetPersonale()
        {
            return db.Personale.OrderBy(p => p.Cognome).ThenBy(p => p.Nome);
        }

        [HttpGet]
        [Route("api/Personale/{id}")]
        public async Task<ActionResult<Personale>> GetPersonale(int id)
        {
            Personale personale = await db.Personale.FindAsync(id);
            if (personale == null)
            {
                return NotFound();
            }
            return Ok(personale);
        }

        /*
        [HttpPut]
        [Route("api/Personale/{id}/update-ldap")]
        public async Task<ActionResult> UpdateLDAP(LDAP ldapAttuale, SaveLDAP ldapInfo)
        {
            if (ldapInfo.LoginLDAP == (ldapAttuale.LoginLDAP ?? "") && ldapInfo.Attivo == ldapAttuale.Attivo)
            {
                return StatusCode(StatusCodes.Status204NoContent);
            }
            if (ldapInfo.LoginLDAP == "")
            {
                ldapAttuale.LoginLDAP = null;
                ldapAttuale.Attivo = false;
                await db.SaveChangesAsync();
                return Ok();
            }
            var ldapNuovo = await db.LDAP.Where(l => l.LoginLDAP == ldapInfo.LoginLDAP && l.LoginLDAP != ldapAttuale.LoginLDAP).FirstOrDefaultAsync();
            if (ldapNuovo != null)
            {
                return Conflict();
            }
            ldapAttuale.LoginLDAP = ldapInfo.LoginLDAP;
            ldapAttuale.Attivo = ldapInfo.Attivo;
            await db.SaveChangesAsync();
            return Ok();
        }
        */

        [HttpPost]
        [Route("api/Personale/{id}/save-ldap")]
        public async Task<ActionResult> SaveLDAP(int id, SaveLDAP ldapInfo)
        {
            var personale = await db.Personale.FindAsync(id);
            if (personale == null)
            {
                return NotFound();
            }
            var ldapAttuale = await db.LDAP.Where(l => l.ID_Personale == personale.ID_Personale).FirstOrDefaultAsync();
            if (ldapAttuale != null)
            {
                return await UpdateLDAP(ldapAttuale, ldapInfo);
            }
            if (ldapInfo.LoginLDAP == "")
            {
                return StatusCode(StatusCodes.Status204NoContent);
            }
            var ldapNuovo = await db.LDAP.Where(l => l.LoginLDAP == ldapInfo.LoginLDAP).FirstOrDefaultAsync();
            if (ldapNuovo != null)
            {
                return Conflict();
            }
            ldapNuovo = new LDAP();
            ldapNuovo.ID_LDAP = db.LDAP.Max(l => l.ID_LDAP) + 1;
            ldapNuovo.ID_Personale = personale.ID_Personale;
            ldapNuovo.LoginLDAP = ldapInfo.LoginLDAP;
            ldapNuovo.Attivo = ldapInfo.Attivo;
            db.LDAP.Add(ldapNuovo);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}