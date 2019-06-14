namespace DemoWebMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("Categorie")]
    [DataContract]
    public partial class Categorie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categorie()
        {
            Produits = new HashSet<Produit>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataMember]
        public int Id { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Nom { get; set; }

        [StringLength(100)]
        [DataMember]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [IgnoreDataMember]
        public virtual ICollection<Produit> Produits { get; set; }
    }
}
