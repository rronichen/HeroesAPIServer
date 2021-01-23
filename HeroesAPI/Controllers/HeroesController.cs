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
using HeroesAPI.Models;


namespace HeroesAPI.Controllers
{   

    [Authorize]
    public class HeroesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private readonly log4net.ILog log = 
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // GET: api/Heroes
        public IQueryable<Hero> GetHeros()
        {
            return db.Heros;
        }

        // GET: api/Heroes/5
        [ResponseType(typeof(Hero))]
        public IHttpActionResult GetHero(string id)
        {

            Hero hero = db.Heros.Find(id);
            if (hero == null)
            {
                return NotFound();
            }

            return Ok(hero);
        }

        // PUT: api/Heroes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHero(string id, Hero hero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hero.id)
            {
                return BadRequest();
            }

            db.Entry(hero).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException exception)
            {
                if (!HeroExists(id))
                {
                    return NotFound();
                }
                else
                {

                   log.Error("error at PUT: api/Heroes/id : ", exception);
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Heroes
        [ResponseType(typeof(Hero))]
        public IHttpActionResult PostHero(Hero hero)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Heros.Add(hero);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                if (HeroExists(hero.id))
                {
                    return Conflict();
                }
                else
                {
                    log.Error("error at POST: api/Heroes : ", exception);
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = hero.id }, hero);
        }

        // DELETE: api/Heroes/5
        [ResponseType(typeof(Hero))]
        public IHttpActionResult DeleteHero(string id)
        {
            Hero hero = db.Heros.Find(id);
            if (hero == null)
            {
                return NotFound();
            }

            db.Heros.Remove(hero);
            db.SaveChanges();

            return Ok(hero);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HeroExists(string id)
        {
            return db.Heros.Count(e => e.id == id) > 0;
        }
    }
}