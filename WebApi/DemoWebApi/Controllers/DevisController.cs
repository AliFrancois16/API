using DemoWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebApi.Controllers
{
    public class DevisController : ApiController
    {
        // GET: api/Devis
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Devis/5
        public Devis Get(float lrg, float lng)
        {
            Devis devis = new Devis() {
                Auteur = "Salam",
                DateDevis= DateTime.Today,
                Metrage = (int)(lrg*lng),
                MainDOeuvre = (int)(lrg * lng)*3,
                Materiaux = (int)(lrg * lng)*5,
                Montant = (int)(lrg * lng)*3+ (int)(lrg * lng)*5
            };


            return devis;
        }

        // POST: api/Devis
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Devis/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Devis/5
        public void Delete(int id)
        {
        }
    }
}
