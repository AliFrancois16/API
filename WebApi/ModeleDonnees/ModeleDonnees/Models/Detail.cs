using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DemoWebMVC.Models
{
    [Table("Details")]
    [DataContract]
    public class Detail
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int IdCommande { get; set; }
        [ForeignKey("IdCommande")]
        public virtual Commande Commande { get; set; }
        [DataMember]
        public int IdProduit { get; set; }
        [ForeignKey("IdProduit")]
        [DataMember]
        public virtual Produit Produit { get; set; }
        [DataMember]
        public int Quantite { get; set; }
    }
}