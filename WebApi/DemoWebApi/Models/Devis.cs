using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DemoWebApi.Models
{
    [DataContract]
    public class Devis
    {
        public int Id { get; set; }
        [DataMember]
        public DateTime DateDevis { get; set; }
        [DataMember]
        public string Auteur { get; set; }
        [DataMember]
        public int Metrage { get; set; }
        [DataMember]
        public float MainDOeuvre { get; set; }
        [DataMember]
        public float Materiaux { get; set; }
        [DataMember]
        public float Montant  { get; set; }

    }
}