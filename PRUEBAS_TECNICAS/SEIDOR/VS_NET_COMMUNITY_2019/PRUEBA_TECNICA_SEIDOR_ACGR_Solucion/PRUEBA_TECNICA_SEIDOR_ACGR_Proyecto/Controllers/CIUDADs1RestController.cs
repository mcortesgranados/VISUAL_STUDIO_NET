using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PRUEBA_TECNICA_SEIDOR_ACGR_Proyecto.Models;

namespace PRUEBA_TECNICA_SEIDOR_ACGR_Proyecto.Controllers
{
    public class CIUDADs1RestController : ApiController
    {
        private PRUEBA_TECNICA_SEIDOR_ACGREntities db = new PRUEBA_TECNICA_SEIDOR_ACGREntities();

        // GET: api/CIUDADs1Rest
        public IQueryable<CIUDAD> GetCIUDAD()
        {
            return db.CIUDAD;
        }

        // GET: api/CIUDADs1Rest/5
        [ResponseType(typeof(CIUDAD))]
        public IHttpActionResult GetCIUDAD(int id)
        {
            CIUDAD cIUDAD = db.CIUDAD.Find(id);
            if (cIUDAD == null)
            {
                return NotFound();
            }

            return Ok(cIUDAD);
        }

        // PUT: api/CIUDADs1Rest/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCIUDAD(int id, CIUDAD cIUDAD)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cIUDAD.CODIGO)
            {
                return BadRequest();
            }

            db.Entry(cIUDAD).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CIUDADExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CIUDADs1Rest
        [ResponseType(typeof(CIUDAD))]
        public IHttpActionResult PostCIUDAD(CIUDAD cIUDAD)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CIUDAD.Add(cIUDAD);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CIUDADExists(cIUDAD.CODIGO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = cIUDAD.CODIGO }, cIUDAD);
        }

        // DELETE: api/CIUDADs1Rest/5
        [ResponseType(typeof(CIUDAD))]
        public IHttpActionResult DeleteCIUDAD(int id)
        {
            CIUDAD cIUDAD = db.CIUDAD.Find(id);
            if (cIUDAD == null)
            {
                return NotFound();
            }

            db.CIUDAD.Remove(cIUDAD);
            db.SaveChanges();

            return Ok(cIUDAD);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CIUDADExists(int id)
        {
            return db.CIUDAD.Count(e => e.CODIGO == id) > 0;
        }
    }
}