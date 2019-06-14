using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DemoWebMVC.Models
{
    [Table("Commandes")]
    [DataContract]
    public class Commande
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public int IdClient { get; set; }
        [IgnoreDataMember]
        public virtual ICollection<Detail> Details { get; set; }

    }
}