namespace DemoWebMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("Produit")]
    [KnownType(typeof(DemoWebMVC.Models.Produit))]
    [DataContract]
    public partial class Produit
    {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Modele { get; set; }

        [DataMember]
        [Column(TypeName = "money")]
        public decimal? Prix { get; set; }

        [DataMember]
        public int? Poids { get; set; }

        [DataMember]
        public int? idCategorie { get; set; }

        [DataMember]
        public virtual Categorie Categorie { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Detail> Details { get; set; }
    }
}
