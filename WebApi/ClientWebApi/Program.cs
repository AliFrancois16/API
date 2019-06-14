using DemoWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClientWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientWebApi();

        }

        private static void ClientWebApi()
        {
            //Instanciation d'un Client HTTP
            HttpClient clientREST = new HttpClient();

            //Uri du Service WebAPI
            clientREST.BaseAddress = new Uri("http://localhost:58716");

            //Remise à zero des en têtes http puis ajout d'une Accept pour obtenir du XML
            clientREST.DefaultRequestHeaders.Clear();
            clientREST.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));


            //Initialisation de la liste des produits
            List<Produit> prods = null;

            //Requêtage et Récuperation d'une réponse HTTP
            HttpResponseMessage reponse = clientREST.GetAsync("/api/Produit").Result;

            //Converstion du résultat en liste de produits "Deserialiser"
            prods = reponse.Content.ReadAsAsync<List<Produit>>().Result;

            //Parcours des Produit pour affichage de nom et prix
            foreach (Produit p in prods)
            {
                Console.WriteLine($"{p.Modele}......{p.Prix}");
            }
        }
    }
}
