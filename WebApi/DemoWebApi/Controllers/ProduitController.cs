using DemoWebMVC.DataAccess;
using DemoWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebApi.Controllers
{
    public class ProduitController : ApiController
    {
        ProduitRepository pRep = new ProduitRepository();
        IRepository<Produit> rep = new EFRepository<Produit>();
        public ProduitController()
        {

        }

        // GET: api/Produit
        public IEnumerable<Produit> Get()
        {
            //return rep.Lister();
            return pRep.Lister();
        }

        // GET: api/Produit/5
        public Produit Get(int id)
        {

            //return rep.Trouver(id);
            return pRep.Trouver(id);
        }

        // POST: api/Produit
        public void Post(Produit p)
        {
            try
            {
                rep.Ajouter(p);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        // PUT: api/Produit/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Produit/5
        public void Delete(int id)
        {
        }
    }
}
