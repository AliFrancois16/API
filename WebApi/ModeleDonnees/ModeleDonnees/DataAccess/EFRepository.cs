using DemoWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebMVC.DataAccess
{
    public class EFRepository<T> : IRepository<T> where T:class
    {
        EDM contexte = new EDM();
        //EDM contexte;
        public EFRepository()
        {
        //    if (HttpContext.Current.Session["contexte"] == null)
        //    {
        //        contexte = new EDM();
        //        HttpContext.Current.Session["contexte"] = contexte;
        //    }
        //    else
        //    {
        //        contexte = (EDM)HttpContext.Current.Session["contexte"];
        //    }
        }

        public T Ajouter(T nouveau)
        {
            try
            {
                T retour =  contexte.Set<T>().Add(nouveau);
                contexte.SaveChanges();
                return retour;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual ICollection<T> Lister()
        {
            return contexte.Set<T>().ToList();
        }

        public T Modifier(T objetAModifie)
        {
            try
            {
                contexte.Entry<T>(objetAModifie).State = 
                    System.Data.Entity.EntityState.Modified;
                contexte.SaveChanges();
                return objetAModifie;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Supprimer(int id)
        {
            try
            {
                contexte.Set<T>().Remove(contexte.Set<T>().Find(id));
                contexte.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual T Trouver(int id)
        {
            try
            {
                return contexte.Set<T>().Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}