using DemoWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebMVC.DataAccess
{
    public class ProduitRepository : EFRepository<Produit>
    {
        EDM context = new EDM();
        public override ICollection<Produit> Lister()
        {
            return context.Produits.Include("Categorie").ToList();
        }

        public override Produit Trouver(int id)
        {
            return context.Produits.Include("Categorie").Where(p=>p.Id==id).First();
        }
       
    }
}